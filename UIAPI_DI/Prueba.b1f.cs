using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace UIAPI_DI
{
    [FormAttribute("UIAPI_DI.Prueba", "Prueba.b1f")]
    class Prueba : UserFormBase
    {
        private SAPbouiCOM.Application objapli;
        private SAPbobsCOM.Company objcompany;

        public Prueba()
        {
        }
        public void Inicio()
        {
            this.objapli = ((SAPbouiCOM.Application)Application.SBO_Application);
            this.objcompany = ((SAPbobsCOM.Company)(this.objapli.Company.GetDICompany()));
        }
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Inicio();
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_0").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_2").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_4").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.EditText3.Active = true;
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_7").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_3").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_6").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_8").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_9").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.EditText EditText0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.Button Button0;

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
           
            SAPbobsCOM.Recordset objreset = (SAPbobsCOM.Recordset)objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            string sql = "select CardCode,CardName from ocrd where CardCode in ('V60000','C20000','L10002','V10000')";
            objreset.DoQuery(sql);
            if (objreset.RecordCount > 0)
            {
                objreset.MoveFirst();
                for (int i = 0; i < objreset.RecordCount; i++)
                {
                    ComboBox1.ValidValues.Add(objreset.Fields.Item("CardCode").Value.ToString(), objreset.Fields.Item("CardName").Value.ToString());
                    //((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_codigo").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("cardcode").Value.ToString();
                    //((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_name").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("cardname").Value.ToString();
                    //((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_correo").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("e_mail").Value.ToString();

                    objreset.MoveNext();
                }

                ComboBox1.ExpandType = SAPbouiCOM.BoExpandType.et_DescriptionOnly;
                //ComboBox1.ExpandType = SAPbouiCOM.BoExpandType.

            }

        }

        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.ComboBox ComboBox1;
    }
}
