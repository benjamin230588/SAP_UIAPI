using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace UIAPI_DI
{
    [FormAttribute("benja23", "Form1.b1f")]
    class Form1 : UserFormBase
    {
        // del modo diseño construimos la interfaz del formulario
        // cada objeto tiene propiedades y eventos y metodos
        // ponemos a la escucha al boton y se realiza la accion de grabar un cliente
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.Button Button1;
        private SAPbobsCOM.Company objcompany;
        private SAPbouiCOM.Application objapli;
        private SAPbouiCOM.Form objform;

        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.cargar();
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_9").Specific));
            //    this.Button2.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button2_ClickBefore);
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_7").Specific));
            this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.Button3.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button3_ClickAfter);
            //   this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            //    this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_8").Specific));
            this.Button5 = ((SAPbouiCOM.Button)(this.GetItem("Item_10").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        public void cargar()
        {
             this.objapli = ((SAPbouiCOM.Application) Application.SBO_Application);
             this.objcompany = ((SAPbobsCOM.Company)(this.objapli.Company.GetDICompany()));
             this.objform = ((SAPbouiCOM.Form)(this.objapli.Forms.ActiveForm));
             this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
             this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
             this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
             this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
             this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
             this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
             this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
             this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_7").Specific));
             this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("item_989").Specific));
             this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_9").Specific));
             //this.Button1.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
        }

     
        private void OnCustomInitialize()
        {

        }
      
        //private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        //{
        //    BubbleEvent = true;
        //    SAPbobsCOM.BusinessPartners objsocio;
           

        //    //if(objform.Mode== SAPbouiCOM.BoFormMode.fm_ADD_MODE)
        //    //{
        //        objsocio = (SAPbobsCOM.BusinessPartners)objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
        //        objsocio.CardCode = "josue123";
        //        objsocio.CardName = "benjamin soto";
        //        objsocio.AdditionalID = "CE";
        //        objsocio.FederalTaxID = "00000";
        //        objsocio.Phone1 = "55555";

        //        int estado = objsocio.Add();
        //        string codigo = EditText0.Value;

        //        //if (estado == 0)
        //        //{
        //        //    objapliMessageBox.Show("Cliente creado");
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("error al crear");
        //        //}

        //    //}

        //    //throw new System.NotImplementedException();

        //}

        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Button Button3;

        private void Button3_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {

            //int estado = objsocio.Add();
            string codigo = EditText0.Value;
           // int estado = objsocio.Add();
            string fono = EditText3.Value;
            string cambio="";
            throw new System.NotImplementedException();

        }

        private void Button3_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.Button Button5;

      

      


       
    }
}