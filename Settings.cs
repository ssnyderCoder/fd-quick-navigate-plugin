using System;
using System.ComponentModel;
using System.Drawing;

namespace QuickNavigatePlugin
{
    [Serializable]
    public class Settings
    {
        #region General

        [Category("General")]
        [DisplayName("Enable navigation by Ctrl+Click")]
        [Description("Go to declaration by Ctrl+Click on the word")]
        [DefaultValue(true)]
        public Boolean CtrlClickEnabled { get;set; }

        [Category("General")]
        [DisplayName("Search in external classpath")]
        [Description("Enable searching files in external classpath")]
        [DefaultValue(true)]
        public Boolean SearchExternalClassPath { get;set; }

        [Category("General")]
        [DisplayName("Cache resources")]
        [Description("Do not read resources each time dialog is opening.")]
        [DefaultValue(false)]
        public Boolean ResourcesCaching { get;set; }

        #endregion

        #region Resource Form

        [Browsable(false)]
        [Category("Resource Form")]
        public Size ResourceFormSize { get;set; }

        [Browsable(true)]
        [Category("Resource Form")]
        [DisplayName("Whole word")]
        [DefaultValue(false)]
        public bool ResourceFormWholeWord { get; set; }

        [Browsable(true)]
        [Category("Resource Form")]
        [DisplayName("Match case")]
        [DefaultValue(false)]
        public bool ResourceFormMatchCase { get; set; }

        #endregion

        #region Type Form

        [Browsable(false)]
        [Category("Type Form")]
        public Size TypeFormSize { get; set; }

        [Browsable(true)]
        [Category("Type Form")]
        [DisplayName("Whole word")]
        [DefaultValue(false)]
        public bool TypeFormWholeWord { get; set; }

        [Browsable(true)]
        [Category("Type Form")]
        [DisplayName("Match case")]
        [DefaultValue(false)]
        public bool TypeFormMatchCase { get; set; }

        #endregion

        #region Outline Form

        [Browsable(false)]
        [Category("Outline Form")]
        public Size OutlineFormSize { get;set; }

        [Browsable(true)]
        [Category("Outline Form")]
        [DisplayName("Whole word")]
        [DefaultValue(false)]
        public bool OutlineFormWholeWord { get;set; }

        [Browsable(true)]
        [Category("Outline Form")]
        [DisplayName("Match case")]
        [DefaultValue(false)]
        public bool OutlineFormMatchCase { get;set; }

        #endregion

    }
}