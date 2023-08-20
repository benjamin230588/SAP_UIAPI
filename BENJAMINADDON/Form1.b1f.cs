using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace BENJAMINADDON
{
    [FormAttribute("BENJAMINADDON.Form1", "Form1.b1f")]
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
            this.btn1 = ((SAPbouiCOM.Button)(this.GetItem("btn1").Specific));
            this.btn1.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.btn1_PressedAfter);
            this.txtcadena1 = ((SAPbouiCOM.EditText)(this.GetItem("txtcad1").Specific));
            this.txtcadena2 = ((SAPbouiCOM.EditText)(this.GetItem("txtcad2").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Button btn1;
        private SAPbouiCOM.EditText txtcadena1;
        private SAPbouiCOM.EditText txtcadena2;

        private void OnCustomInitialize()
        {

        }

        private void btn1_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            // hacer referencia a aplication y mostrar mensaje de lo escrito

            //SAPbouiCOM.EditText oEditText = (SAPbouiCOM.EditText)OwnerForm.Items.Item("31_U_E").Specific;
            txtcadena2.Value = "sara";

            
        }

       
    }
}