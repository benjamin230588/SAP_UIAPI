using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;
//using SAPbouiCOM;

namespace AddonBen
{
    [FormAttribute("AddonBen.Articulo", "Articulo.b1f")]
    class Articulo : UserFormBase
    {
        SAPbouiCOM.Form oForm;
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
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_12").Specific));
            this.Button1.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button1_PressedAfter);
            this.Button1.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button1_ClickAfter);
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_13").Specific));
            this.Matrix0.ClickAfter += new SAPbouiCOM._IMatrixEvents_ClickAfterEventHandler(this.Matrix0_ClickAfter);
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
            oForm = Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
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
        private SAPbouiCOM.Button Button1;

        private void Button1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
           
        }

        private void Button1_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            oForm.Close();
            //throw new System.NotImplementedException();
            //Application.SBO_Application.OpenForm(SAPbouiCOM.BoFormObjectEnum.fo_PurchaseInvoice, "", "50");

            //SAPbouiCOM.Form udoForm = Application.SBO_Application.OpenForm(SAPbouiCOM.BoFormObjectEnum.fo_UserDefinedObject, "clienteudo", "");

            //int udoFormType = Application.SBO_Application.Forms.("TU_NOMBRE_UDO", BoFormAttributeType.fat_FormTypeEx);

            //// Obtener el número de formulario del UDO
            //int udoFormNumber = Application.SBO_Application.Forms.GetFormAttribute("TU_NOMBRE_UDO", BoFormAttributeType.fat_FormNumber);

            // Obtener referencia al formulario del UDO
            //SAPbouiCOM.Form oUDOForm = Application.SBO_Application.Forms.GetFormByTypeAndCount(pVal.FormTypeCount, pVal.FormTypeCount);

            //SAPbobsCOM.Company oCompany =  (SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany();
            //SAPbobsCOM.UserObjectsMD udo = (SAPbobsCOM.UserObjectsMD)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD);
            //if (udo.GetByKey("clienteudo"))
            //{
            //    //int formType = udo.;
            //    //int formNumber = udo.ObjectNumber;
            //}

            //Form oUDOForm = oSBO_Application.Forms.GetFormByTypeAndCount(udoFormType, udoFormNumber);


            //SAPbouiCOM.Form udoForm = Application.SBO_Application.Forms.GetForm("UDO_FT_clienteudo", 1); // Reemplaza -12345 con el tipo de objeto definido por el usuario (UDO)

            //SAPbouiCOM.Item buttonItem = udoForm.Items.Add("btnI5D", SAPbouiCOM.BoFormItemTypes.it_BUTTON);
            //////oButton = (Button)oItem.Specific;
            //buttonItem.Top = 20; // Ajusta la posición del botón
            //buttonItem.Left = 100;
            //buttonItem.Width = 100;
            //buttonItem.Height = 20;
            //((SAPbouiCOM.Button)buttonItem.Specific).Caption = "Mi Botón";
            //buttonItem.FromPane = 0;
            //buttonItem.ToPane = 0;
            //buttonItem.Visible = true;

        }

        private SAPbouiCOM.Matrix Matrix0;

        private void Matrix0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            throw new System.NotImplementedException();

        }
    }
}