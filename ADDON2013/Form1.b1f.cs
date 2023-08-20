using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace ADDON2013
{
    [FormAttribute("ADDON2013.Form1", "Form1.b1f")]
    class Form1 : UserFormBase
    {
        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_1").Specific));
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.btnguardar = ((SAPbouiCOM.Button)(this.GetItem("btnguardar").Specific));
            this.btnguardar.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.btnguardar_ClickAfter);
            this.gridbenja = ((SAPbouiCOM.Grid)(this.GetItem("Item_2").Specific));
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_4").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_5").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_7").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

       

        private void OnCustomInitialize()
        {

        }
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.Button btnguardar;

        private void btnguardar_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            Application.SBO_Application.MessageBox("hola benjamin");
        }

        private SAPbouiCOM.Grid gridbenja;
        private SAPbouiCOM.Form objform1;
        private SAPbouiCOM.DataTable objtabla;
        

        private void Button0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            //BubbleEvent = true;
           // objform1 = Application.SBO_Application.Forms.ActiveForm;
            //objtabla = objform1.DataSources.DataTables.Add("benja");
            //objtabla.ExecuteQuery("select * from OCRD");
            // elegir las columnas 
            //gridbenja.DataTable = objtabla;

           string oQuery = string.Format(@"SELECT TOP 50 ""CardCode"" ""CodSN"",""CardName"" ""NombSN"",""CardType"" from ""OCRD"" ");
            gridbenja.DataTable.ExecuteQuery(oQuery);
        }

        private SAPbouiCOM.CheckBox CheckBox0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.ComboBox ComboBox0;
    }
}