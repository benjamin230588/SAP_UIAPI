using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace UIAPI_DI
{
    [FormAttribute("UIAPI_DI.Matriz", "Matriz.b1f")]
    class Matriz : UserFormBase
    {
        public Matriz()
        {

        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Inicio();
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_1").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Button Button0;
        public void Inicio()
        {
            this.objapli = ((SAPbouiCOM.Application)Application.SBO_Application);
            this.objcompany = ((SAPbobsCOM.Company)(this.objapli.Company.GetDICompany()));
        }

      
        private SAPbouiCOM.Application objapli;
        private SAPbobsCOM.Company objcompany;


        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.Matrix Matrix0;

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            SAPbobsCOM.Recordset objreset = (SAPbobsCOM.Recordset)objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            string sql = "select cardcode,cardname,e_mail from ocrd where CardCode in ('V60000','C20000','L10002','V10000')";
            objreset.DoQuery(sql);
            if(objreset.RecordCount > 0)
            {
                for( int i = 0 ; i < objreset.RecordCount ; i++ )
                {
                    Matrix0.AddRow();
                    ((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_codigo").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("cardcode").Value.ToString();
                    ((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_name").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("cardname").Value.ToString();
                    ((SAPbouiCOM.EditText)Matrix0.Columns.Item("Col_correo").Cells.Item(i + 1).Specific).Value = objreset.Fields.Item("e_mail").Value.ToString();

                    objreset.MoveNext();
                }

            }

        }
    }
}
