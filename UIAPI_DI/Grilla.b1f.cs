using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace UIAPI_DI
{
    [FormAttribute("UIAPI_DI.Grilla", "Grilla.b1f")]
    class Grilla : UserFormBase
    {
        public Grilla()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            Inicio();
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_0").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_3").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }
        public  void Inicio()
        {
            this.objapli = ((SAPbouiCOM.Application)Application.SBO_Application);
        }

        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Form objform1;
        private SAPbouiCOM.DataTable objtabla;
        private SAPbouiCOM.Application objapli;



        private void OnCustomInitialize()
        {

        }

       

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            // grilla solo se muestra la informacion
            BubbleEvent = true;
            objform1 = objapli.Forms.ActiveForm;
            objtabla = objform1.DataSources.DataTables.Add("benja");
            objtabla.ExecuteQuery("select * from OCRD");
            // elegir las columnas 
            Grid0.DataTable = objtabla;
            //throw new System.NotImplementedException();

        }
    }
}
