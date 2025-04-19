using System;
using System.Collections.Generic;
using SAPbouiCOM.Framework;

namespace AddonBen
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application oApp = null;
                if (args.Length < 1)
                {
                    oApp = new Application();
                }
                else
                {
                    oApp = new Application(args[0]);
                }
                Menu MyMenu = new Menu();
                //MyMenu.AddMenuItems();
                //oApp.RegisterMenuEventHandler(MyMenu.SBO_Application_MenuEvent);
                Application.SBO_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler(SBO_ItemEvent);
              
                Application.SBO_Application.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(SBO_Application_AppEvent);
                oApp.Run();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        static void SBO_Application_AppEvent(SAPbouiCOM.BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
                    //Exit Add-On
                    System.Windows.Forms.Application.Exit();
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_FontChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_ServerTerminition:
                    break;
                default:
                    break;
            }
        }

        static void SBO_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                 if (pVal.FormTypeEx == "139")
            {

                if (pVal.BeforeAction == false  && pVal.EventType == SAPbouiCOM.BoEventTypes.et_f)
                {

                    //SAPbouiCOM.Form oFormactive = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    //int numero = oFormactive.TypeCount;
                    SAPbouiCOM.Form oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", pVal.FormTypeCount);
                    SAPbouiCOM.ComboBox oMTX = (SAPbouiCOM.ComboBox)oForm.Items.Item("9").Specific;
                    oMTX.Select("2", SAPbouiCOM.BoSearchKey.psk_ByValue);

                    // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                    ////SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                    ////SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                    ////oUDFtxtPeso.Value = "hola";



                }

                if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_VALIDATE)
                {


                    // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                    SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                    SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                    oUDFtxtPeso.Value = "hola";



                }
               
                //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //{
                //    if (Globals.oOwnerForm != null)
                //    {
                //        if (Globals.oOwnerForm.TypeEx == "140")
                //        {
                //            var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-140", 1);
                //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_STR_FE_GRE_Peso").Specific;//
                //            oUDFtxtPeso.Value = Peso;

                //        }

                //    }
                //}

                //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //{
                   
                       
                //           // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                //            oUDFtxtPeso.Value = "hola";

                        

                // }
                //&& pVal.ItemUID == "U_cambio"  && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS
                //if (pVal.BeforeAction == false && pVal.ItemUID == "U_cambio"  && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //{

                //    if (pVal.FormTypeEx == "-139")
                //    {



                //        //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //{
                //        //    if (Globals.oOwnerForm != null)
                //        //    {
                //        //        if (Globals.oOwnerForm.TypeEx == "140")
                //        //        {
                //        //            var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-140", 1);
                //        //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_STR_FE_GRE_Peso").Specific;//
                //        //            oUDFtxtPeso.Value = Peso;

                //        //        }

                //        //    }
                //        //}

                //        //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //{


                //        //           // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                //        //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                //        //            oUDFtxtPeso.Value = "hola";



                //        // }
                //        //&& pVal.ItemUID == "U_cambio"  && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS
                //        //if (pVal.BeforeAction == false && pVal.ItemUID == "U_cambio" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //{

                //        //    if (pVal.FormTypeEx == "-139")
                //        //    {



                //        //        //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //        //{
                //        //        //    if (Globals.oOwnerForm != null)
                //        //        //    {
                //        //        //        if (Globals.oOwnerForm.TypeEx == "140")
                //        //        //        {
                //        //        //            var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //        //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-140", 1);
                //        //        //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_STR_FE_GRE_Peso").Specific;//
                //        //        //            oUDFtxtPeso.Value = Peso;

                //        //        //        }

                //        //        //    }
                //        //        //}

                //        //        //if (pVal.BeforeAction == false && pVal.ItemUID == "38" && pVal.ColUID == "11" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //        //{


                //        //        //           // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //        //            SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                //        //        //            SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                //        //        //            oUDFtxtPeso.Value = "hola";



                //        //        // }
                //        //        //&& pVal.ItemUID == "U_cambio"  && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS
                //        //        if (pVal.BeforeAction == false && pVal.ItemUID == "U_cambio" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
                //        //        {

                //        //            SAPbouiCOM.Form oFormactive = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                //        //            int numero = oFormactive.TypeCount;
                //        //            SAPbouiCOM.Form oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("139", 1);
                //        //            SAPbouiCOM.EditText oMTX = (SAPbouiCOM.EditText)oForm.Items.Item("14").Specific;
                //        //            oMTX.Value = "delia";

                //        //            // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //            ////SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                //        //            ////SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                //        //            ////oUDFtxtPeso.Value = "hola";



                //        //        }
                               
                //        //    }
                //        //    //SAPbouiCOM.Form oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("139", 1);
                //        //    //SAPbouiCOM.EditText oMTX = (SAPbouiCOM.EditText)oForm.Items.Item("14").Specific;
                //        //    //oMTX.Value = "delia";

                //        //    // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                //        //    ////SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                //        //    ////SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                //        //    ////oUDFtxtPeso.Value = "hola";



                //        //}
                //    }
                    //SAPbouiCOM.Form oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("139", 1);
                    //SAPbouiCOM.EditText oMTX = (SAPbouiCOM.EditText)oForm.Items.Item("14").Specific;
                    //oMTX.Value = "delia";
                      
                    // var Peso = BusinessFunctions.GetPesoKilo(Globals.oMTXGR).ToString();
                    ////SAPbouiCOM.Form oFormUF = (SAPbouiCOM.Form)Application.SBO_Application.Forms.GetForm("-139", 1);
                    ////SAPbouiCOM.EditText oUDFtxtPeso = (SAPbouiCOM.EditText)oFormUF.Items.Item("U_cambio").Specific;//
                    ////oUDFtxtPeso.Value = "hola";



                
               }
            }
            catch( Exception ex){

            }

           
            }
           
           




        }
    }

