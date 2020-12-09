// ***********************************************************************
// Assembly         : PathFinder
// Author           : xenonsmurf
// Created          : 07-01-2020
//
// Last Modified By : xenonsmurf
// Last Modified On : 07-13-2020
// ***********************************************************************
// <copyright file="Settings.Designer.cs" company="Xenonsmurf">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace PathFinder.Properties {


    /// <summary>
    /// Class Settings. This class cannot be inherited.
    /// Implements the <see cref="System.Configuration.ApplicationSettingsBase" />
    /// </summary>
    /// <seealso cref="System.Configuration.ApplicationSettingsBase" />
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        /// <summary>
        /// The default instance
        /// </summary>
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        /// <summary>
        /// Gets the default.
        /// </summary>
        /// <value>The default.</value>
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}
