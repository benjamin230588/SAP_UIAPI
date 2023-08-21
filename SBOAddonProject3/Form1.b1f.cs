using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace SBOAddonProject3
{
    [FormAttribute("SBOjbenja", "Form1.b1f")]
    class Form1 : UserFormBase
    {
        SAPbouiCOM.Form oForm;
        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_0").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("hhh").Specific));
            this.Button0.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button0_PressedAfter);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("0").Specific));
            this.Button1.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button1_PressedAfter);
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_2").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            //this.LoadAfter += new LoadAfterHandler(this.Form_LoadAfter);

        }

        private SAPbouiCOM.EditText EditText0;

        private void OnCustomInitialize()
        {
            oForm = Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);

        }

        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.Button Button0;

        private void Button0_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            /*
            string valor = EditText0.Value;
            string sss = "sss";
            SAPbouiCOM.Item objitem;
            SAPbouiCOM.Button oButton;
            objitem = oForm.Items.Add("btnEntrega", SAPbouiCOM.BoFormItemTypes.it_BUTTON);
            //Inicializando el objeto boton con la referencia del objeto item
            oButton = (SAPbouiCOM.Button)objitem.Specific;
            //Agregando propiedades al boton
            oButton.Caption = "Entrega";
            //agregando posicio del boton
            objitem.Top = oForm.Height - (objitem.Height + 48);
            objitem.Left = (objitem.Width + 20) + 60;*/
            string ErrorMSG = string.Empty;
            int ErroCode = 1;
            SAPbobsCOM.Company oCompany;

            oCompany= (SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany();
            SAPbobsCOM.UserTable oUTable = (SAPbobsCOM.UserTable)oCompany.UserTables.Item("BENJA123");
           // oUTable.GetByKey("1");
            oUTable.Code="2555";
            oUTable.Name = "behhahha";

            //oUTable.UserFields.Fields.Item("U_BodyMail").Value = "12345";
            //oUTable.UserFields.Fields.Item("U_FooterMail").Value = "benja123";
            ErroCode = oUTable.Add();
            if (ErroCode != 0)
            {
                //Globals.oCompany.GetLastError(out ErroCode, out ErrorMSG);
                //DevsPeru.Framework.UI.Messages.ShowError(ErrorMSG);
            }
            
        }

        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.EditText EditText2;

        private void Button1_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            try
            {
                SAPbobsCOM.Company oCompany;
                string ErrorMSG = string.Empty;
                int ErrorCode = 1;
                oCompany = (SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany();

                SAPbobsCOM.UserObjectsMD oUserDataObject = (SAPbobsCOM.UserObjectsMD)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD);
                

                oUserDataObject.CanCancel = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.CanClose = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.CanDelete = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.CanFind = SAPbobsCOM.BoYesNoEnum.tYES;
                oUserDataObject.CanLog = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.ObjectType = SAPbobsCOM.BoUDOObjType.boud_MasterData;
                oUserDataObject.ManageSeries = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.RebuildEnhancedForm = SAPbobsCOM.BoYesNoEnum.tNO;
                oUserDataObject.Code = "benjaudo33";
                oUserDataObject.Name = "udo domingo";
                oUserDataObject.TableName = "SABADOUDO";

                ErrorCode = oUserDataObject.Add();
               // System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserDataObject);
                // Globals.oCompany.GetLastError(out ErrorCode, out ErrorMessage);

            }
            catch(Exception ex){

            }
           

        }

      
    }
}