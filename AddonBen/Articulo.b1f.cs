using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace AddonBen
{
    [FormAttribute("AddonBen.Articulo", "Articulo.b1f")]
    class Articulo : UserFormBase
    {
        public Articulo()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_5").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_6").Specific));
            this.PictureBox0 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_7").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_9").Specific));
            this.Folder3 = ((SAPbouiCOM.Folder)(this.GetItem("Item_10").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_11").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.StaticText StaticText0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.PictureBox PictureBox0;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.Folder Folder3;
        private SAPbouiCOM.Button Button0;
    }
}