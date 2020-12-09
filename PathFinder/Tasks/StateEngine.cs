// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-03-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="StateEngine.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace PathFinder.Tasks
{
    /// <summary>
    /// Class StateEngine.
    /// </summary>
    public class StateEngine
    {
        /// <summary>
        /// Worker Thread
        /// </summary>
        private readonly BackgroundWorker _workerThread;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateEngine"/> class.
        /// </summary>
        public StateEngine()
        {
            States = new List<State>();

            _workerThread = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            _workerThread.DoWork += WorkerThread_DoWork;
            _workerThread.RunWorkerCompleted += WorkerThreadRunWorkerCompleted;
        }

        /// <summary>
        /// Cancelation Token Source
        /// </summary>
        /// <value>The CTS.</value>
        public CancellationTokenSource Cts { get; set; }

        /// <summary>
        /// Gambit thats currently running
        /// </summary>
        /// <value>The state of the current.</value>
        public State CurrentState { get; private set; }

        /// <summary>
        /// Current frame count, used for checking if its time to run a state based on it's
        /// frequency (can overflow)
        /// </summary>
        /// <value>The frame count.</value>
        public int FrameCount { get; private set; }

        /// <summary>
        /// Whether the engine is running or not
        /// </summary>
        /// <value><c>true</c> if this instance is running; otherwise, <c>false</c>.</value>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// List of all loaded gambits
        /// </summary>
        /// <value>The states.</value>
        public List<State> States { get; }

        /// <summary>
        /// Adds a state to the list of states that we're currently running
        /// </summary>
        /// <param name="state">State that we want to add</param>
        public void AddState(State state)
        {
            // If the state is already in the list, there's no need to add it again.
            if (!States.Contains(state))
            {
                States.Add(state);

                // We implemented the IComparer, and IComparable interfaces on the State class! so
                // we can simply call Sort() to get the highest priorities on top
                States.Sort();
            }
        }

        /// <summary>
        /// Clears the states.
        /// </summary>
        public void ClearStates()
        {
            Stop();
            States.Clear();
        }

        /// <summary>
        /// Enables the state.
        /// </summary>
        /// <param name="stateName">Name of the state.</param>
        /// <param name="isEnabled">if set to <c>true</c> [is enabled].</param>
        public void EnableState(string stateName, bool isEnabled)
        {
        }

        /// <summary>
        /// Pulse function, takes care of transitions between states and executing each states Logic
        /// </summary>
        public virtual void Pulse()
        {
            // Check if its time to pulse
            FrameCount++;

            // This starts at the highest priority gambit and iterates its way to the lowest priority
            foreach (State state in States)
            {
                // Check if we need to run this state
                if (state.Frequency % FrameCount != 0)
                {
                    continue;
                }

                // Check if the state requested to be run
                if (state.NeedToRun)
                {
                    //if we are changing to a new state then exit the old one and enter the new one
                    if (state != CurrentState)
                    {
                        // If we are in a state exit it
                        if (CurrentState != null)
                        {
                            CurrentState.Exit();
                        }

                        // Track new state
                        CurrentState = state;
                        // Enter new state
                        CurrentState.Enter();
                    }

                    // Update state
                    state.Update();

                    // Break out of the iteration, as we found a state that has run, we don't want
                    // to run any more states this time around
                    break;
                }
            }
        }

        /// <summary>
        /// Removes the state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void RemoveState(State state)
        {
            // If the state is already in the list, there's no need to add it again.
            if (States.Contains(state))
            {
                States.Remove(state);

                // We implemented the IComparer, and IComparable interfaces on the State class! so
                // we can simply call Sort() to get the highest priorities on top
                States.Sort();
            }
        }

        /// <summary>
        /// Starts the engine
        /// </summary>
        /// <param name="pulsesPerSecond">Number of pulses we want to be executed per second</param>
        public void Start(int pulsesPerSecond)
        {
            if (!_workerThread.IsBusy)
            {
                // Create a new Token
                Cts = new CancellationTokenSource();

                // set our states cancellation token.
                foreach (var state in States)
                {
                    state.Token = Cts.Token;
                }

                // Time we need to sleep to get our desired pulses per second.
                int sleepTime = 200 / pulsesPerSecond;

                // Start our thread
                _workerThread.RunWorkerAsync(sleepTime);

                // Tell everyone that the engine is running.
                IsRunning = true;
            }
        }

        /// <summary>
        /// Stops the engine, exiting all currently running states
        /// </summary>
        public void Stop()
        {
            if (!_workerThread.IsBusy)
            {
                // If we're not running there's nothing to do.
                return;
            }

            if (_workerThread.IsBusy)
            {
                // Cancel our token source as to quickly exit any loops.
                Cts.Cancel();

                // End all the loaded states.
                foreach (State state in States)
                {
                    if (state.IsRunning)
                    {
                        state.Exit();
                    }
                }
            }
            // Stop the worker thread.
            _workerThread.CancelAsync();
        }

        /// <summary>
        /// Starts the engine loop
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
        private void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            // This will imitate a games FPS and attempt to 'pulse' each frame
            while (!_workerThread.CancellationPending)
            {
                Pulse();

                // Sleep for some time before next pulse
                Thread.Sleep((int)e.Argument);
            }
        }

        /// <summary>
        /// Workers the thread run worker completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.
        /// </param>
        private void WorkerThreadRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CurrentState = null;
            IsRunning = false;
        }
    }
}