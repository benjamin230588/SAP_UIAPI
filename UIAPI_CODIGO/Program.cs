using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using SAPbouiCOM;
using System.IO;
using System.Xml;


namespace UIAPI_CODIGO
{
    class Program
    {
        public static Application SBO_Application = null;
        public static SAPbobsCOM.Company oCompany = null;
        // puntos a estudiar
        // modos de formulario
        // eventos de controles
        static void Main(string[] args)
        {
            ConexionUIAPI();
            //agregarmenus();
            // benjamin huama soto
            
           Menus();
            //SBO_Application.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(SBO_Application_sistema);
           
            SBO_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler(SBO_Application_ItemEvent);
            SBO_Application.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler(SBO_Application_MenuEvent);
            System.Windows.Forms.Application.Run();
        }

        public static void ConexionUIAPI()
        {
            try
            {
                SboGuiApi oSboGuiApi = new SboGuiApi();
                string sConnStr = Environment.GetCommandLineArgs().GetValue(1).ToString();
                oSboGuiApi.Connect(sConnStr);

                SBO_Application = oSboGuiApi.GetApplication(-1);
                oCompany = (SAPbobsCOM.Company)SBO_Application.Company.GetDICompany();
                SBO_Application.StatusBar.SetText("EXITO - Conexion UI API Exitosa", BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Success);
                SBO_Application.MessageBox("hoy es domingo");
                oSboGuiApi = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void agregarmenus()
        {
            try
            {
                SAPbouiCOM.Menus myMenu = null;
                SAPbouiCOM.MenuItem myMenuItem = null;
                SAPbouiCOM.MenuCreationParams myCreationPAckage = null;

                //Obtines todos los menu de SAP
                myMenu = SBO_Application.Menus;
                //Pregunta si existe el menu en caso de que exista lo elimina para volverlo a crear 
                if (myMenu.Exists("TM_Addon"))
                {
                    myMenu.RemoveEx("TM_Addon");
                    Console.WriteLine("Borreo el menu TM_Addon");
                }
                //posicionamos el nivel del menu
                myMenuItem = SBO_Application.Menus.Item("43520");
                myMenu = myMenuItem.SubMenus;
                //Instanciamos el objeto para agregar las propiedades
                myCreationPAckage = (SAPbouiCOM.MenuCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
                //Creamos el Submenu con sis propiedades
                //¿Que tipo de meu es?(Tipo folder,Tipo unico o separado)
                myCreationPAckage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
                //ID del Menu
                myCreationPAckage.UniqueID = "TM_Addon";
                //Dexcripcion del Menu
                myCreationPAckage.String = "Benja UI API";
                //Icono del menu
                //myCreationPAckage.Image = @"C:\Users\Administrator\Documents\UI2.bmp";//16*16Pixel en formato bmp o bitmap
                //Posicion del menu(-1 pone menu hasta el final)
                myCreationPAckage.Position = -1;
                //Agregamos el menu a SAP
                myMenu.AddEx(myCreationPAckage);


                /*Agregar un submenu al menu que se creo*/
                myMenu = SBO_Application.Menus;
                //Pregunta si existe el menu en caso de que exista lo elimina para volverlo a crear 
                if (myMenu.Exists("TM_CreaSN"))
                {
                    myMenu.RemoveEx("TM_CreaSN");
                    Console.WriteLine("Borreo el menu TM_CreaSN");
                }
                //posicionamos el nivel del menu
                myMenuItem = SBO_Application.Menus.Item("TM_Addon");
                myMenu = myMenuItem.SubMenus;
                //Instanciamos el objeto para agregar las propiedades
                myCreationPAckage = (SAPbouiCOM.MenuCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
                //Creamos el Submenu con sis propiedades
                //¿Que tipo de meu es?(Tipo folder,Tipo unico o separado)
                myCreationPAckage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                //ID del Menu
                myCreationPAckage.UniqueID = "TM_CreaSN";
                //Dexcripcion del Menu
                myCreationPAckage.String = "Crear SN";
                //Icono del menu
                //myCreationPAckage.Image = @"C:\Users\Administrator\Documents\UI2.bmp";//16*16Pixel en formato bmp o bitmap
                //Posicion del menu(-1 pone menu hasta el final)
                myCreationPAckage.Position = -1;
                //Agregamos el menu a SAP
                myMenu.AddEx(myCreationPAckage);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error General - " + ex.ToString());
            }
        }


        public static void  Menus(){

             try
            {
                SAPbouiCOM.Menus myMenu = null;
                SAPbouiCOM.MenuItem myMenuItem = null;
                SAPbouiCOM.MenuCreationParams myCreationPAckage = null;

              
                myMenu = SBO_Application.Menus;
                myMenuItem = SBO_Application.Menus.Item("43520");
                myMenu = myMenuItem.SubMenus;
                int hijos = myMenuItem.SubMenus.Count;
                myCreationPAckage = (SAPbouiCOM.MenuCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);     
                myCreationPAckage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;     
                myCreationPAckage.UniqueID = "be_001"; 
                myCreationPAckage.String = "Formulario xml";
                myCreationPAckage.Position = hijos + 1;
                
                myMenu.AddEx(myCreationPAckage);


                 // 1 item

                myMenu = SBO_Application.Menus;
                myMenuItem = SBO_Application.Menus.Item("be_001");
                myMenu = myMenuItem.SubMenus;
               
                myCreationPAckage = (SAPbouiCOM.MenuCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
               
                myCreationPAckage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
              
                myCreationPAckage.UniqueID = "be_002";
               
                myCreationPAckage.String = "Formulario";
               
                myCreationPAckage.Position = 1;
                
                myMenu.AddEx(myCreationPAckage);

                 // 2 item 
                myMenu = SBO_Application.Menus;
                myMenuItem = SBO_Application.Menus.Item("be_001");
                myMenu = myMenuItem.SubMenus;

                myCreationPAckage = (SAPbouiCOM.MenuCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);

                myCreationPAckage.Type = SAPbouiCOM.BoMenuType.mt_STRING;

                myCreationPAckage.UniqueID = "be_003";

                myCreationPAckage.String = "Mensaje";

                myCreationPAckage.Position = 2;

                myMenu.AddEx(myCreationPAckage);
             }
              catch (Exception ex)
            {
                Console.WriteLine("Error General - " + ex.ToString());
            }
        }

        public static void SBO_Application_ItemEvent(string FormUID, ref ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (pVal.FormTypeEx == "UDO_FT_clienteudo")
                {
                    if (pVal.EventType == SAPbouiCOM.BoEventTypes.et_FORM_LOAD && pVal.BeforeAction == false)
                    {
                        //Form oForm = SBO_Application.Forms.Item(FormUID);
                        //SAPbouiCOM.Form oUDOForm = SBO_Application.Forms.Item(FormUID);
                        SAPbouiCOM.Form oUDOForm = SBO_Application.Forms.Item(FormUID);
                        //GetFormByTypeAndCount(pVal.FormType, pVal.FormTypeCount);

                       

                        //SAPbouiCOM.Item buttonItem = oUDOForm.Items.Add("btnI5D", BoFormItemTypes.it_BUTTON);
                        SAPbouiCOM.Item oItem;
                        SAPbouiCOM.Button oButton;
                        oItem = oUDOForm.Items.Add("btn256", SAPbouiCOM.BoFormItemTypes.it_BUTTON);
                        //Inicializando el objeto boton con la referencia del objeto item
                        oButton = (SAPbouiCOM.Button)oItem.Specific;
                        //Agregando propiedades al boton
                        oButton.Caption = "btnEntrega";
                        //agregando posicio del boton
                        oItem.Height = 30;
                        oItem.Width = 90;
                        oItem.Top = 70;
                        oItem.Left = (oItem.Width + 20) + 50;
                        ////oButton = (Button)oItem.Specific;
                        //buttonItem.Top = 20; // Ajusta la posición del botón
                        //buttonItem.Left = 100;
                        ////buttonItem.Width = 100;
                        //buttonItem.Height = 20;
                        //((SAPbouiCOM.Button)buttonItem.Specific).Caption = "Mitodoón";
                        //oItem.FromPane = 0;
                        //oItem.ToPane = 0;
                        oItem.Visible = true;
                    }
                   
                }

                //numero de menu 
                // numero de formulario
                // numero de control 
                //Pedidos de Venta
                // 139 es el id del formulario
                //UDO_FT_clienteudo
                //if (pVal.FormTypeEx == "UDO_FT_clienteudo")
                //{
                //    if (pVal.EventType == BoEventTypes.et_FORM_LOAD && pVal.BeforeAction == true)
                //    {
                //        //Form oForm = SBO_Application.Forms.Item(FormUID);
                //         //SAPbouiCOM.Form oUDOForm = SBO_Application.Forms.Item(FormUID);
                //         SAPbouiCOM.Form oUDOForm = SBO_Application.Forms.GetFormByTypeAndCount(pVal.FormType, pVal.FormTypeCount);

                //        //Item oItem;
                //        //Button oButton;
                //        //oItem = oForm.Items.Add("btn256", BoFormItemTypes.it_BUTTON);
                //        ////Inicializando el objeto boton con la referencia del objeto item
                //        //oButton = (Button)oItem.Specific;
                //         //Agregando propiedades al boton
                //        //oButton.Caption = "Entrega";
                //        ////agregando posicio del boton
                //        //oItem.Height = 15;
                //        ////oItem.Width = 30;
                //        //oItem.Top = oForm.Height - (oItem.Height + 40);
                //        //oItem.Left = (oItem.Width + 20) + 50;

                //         //SAPbouiCOM.Item buttonItem = oUDOForm.Items.Add("btnI5D", BoFormItemTypes.it_BUTTON);
                //        Item oItem;
                //        Button oButton;
                //        oItem = oUDOForm.Items.Add("btn256", BoFormItemTypes.it_BUTTON);
                //        //Inicializando el objeto boton con la referencia del objeto item
                //        oButton = (Button)oItem.Specific;
                //        //Agregando propiedades al boton
                //        oButton.Caption = "btnEntrega";
                //        //agregando posicio del boton
                //        oItem.Height = 15;
                //        //oItem.Width = 30;
                //        oItem.Top = 40;
                //        oItem.Left = (oItem.Width + 20) + 50;
                //         ////oButton = (Button)oItem.Specific;
                //         //buttonItem.Top = 20; // Ajusta la posición del botón
                //         //buttonItem.Left = 100;
                //         ////buttonItem.Width = 100;
                //         //buttonItem.Height = 20;
                //         //((SAPbouiCOM.Button)buttonItem.Specific).Caption = "Mitodoón";
                //        oItem.FromPane = 0;
                //        oItem.ToPane = 0;
                //        oItem.Visible = true;
                //    }
                //    if (pVal.EventType == BoEventTypes.et_CLICK && pVal.BeforeAction == true && pVal.ItemUID == "btnEntrega")
                //    {
                //        //SAPbouiCOM.EditText txt = (SAPbouiCOM.EditText)oForm.Items.Item("Item_1").Specific;
                //        //SBO_Application.MessageBox("presionaste");
                //        SBO_Application.ActivateMenuItem("51201");
                //        //SAPbobsCOM.BusinessPartners objsocio;

                //        //objsocio = (SAPbobsCOM.BusinessPartners)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
                //        //objsocio.CardCode = "codigo23";
                //        //objsocio.CardName = "benjamin josue";
                //        //objsocio.AdditionalID = "CE";
                //        //objsocio.FederalTaxID = "00000";
                //        //objsocio.Phone1 = "55555";

                //        //int estado = objsocio.Add();



                //    }
                //}
                if (pVal.FormTypeEx == "60006")
                {
                    if (pVal.EventType == BoEventTypes.et_CLICK && pVal.BeforeAction == true && pVal.ItemUID == "btnEntrega")
                {
                    Form oForm = SBO_Application.Forms.Item(FormUID);
                    //SBO_Application.ActivateMenuItem("51201");
                  //  SBO_Application.MessageBox("presionaste otra vez");
                    //SAPbobsCOM.BusinessPartners objsocio;
                    //SAPbouiCOM.EditText txt = (SAPbouiCOM.EditText)oForm.Items.Item("be_2360").Specific;
                    //objsocio = (SAPbobsCOM.BusinessPartners)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
                    //objsocio.CardCode = "codigo23";
                    //objsocio.CardName = "benjamin josue";
                    //objsocio.AdditionalID = "CE";
                    //objsocio.FederalTaxID = "00000";
                    //objsocio.Phone1 = "55555";

                    //int estado = objsocio.Add();



                }
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        public static void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (pVal.MenuUID == "be_003" && pVal.BeforeAction == false)
                {
                    SBO_Application.MessageBox("diste click");
                   

                }

                if (pVal.MenuUID == "1282" )
                {
                    //SBO_Application.MessageBox("click en nuevo");
                    // opero en form activo
                    SAPbouiCOM.Form currentForm = SBO_Application.Forms.ActiveForm;
                    SBO_Application.MessageBox(currentForm.UniqueID.ToString());


                }
                if (pVal.MenuUID == "be_002" && pVal.BeforeAction == false)
                {
                    //SBO_Application.MessageBox("formulario por  codigo");
                    // puedo abrir formulario 
                    SAPbouiCOM.Form objform;
                    SAPbouiCOM.FormCreationParams objpara;
                    SAPbouiCOM.Item objitem;

                    objpara = (SAPbouiCOM.FormCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
                    objpara.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed;
                    objpara.UniqueID = "benjauuu"; 
                    objform = SBO_Application.Forms.AddEx(objpara);
                    objform.Title = "benjamin huaman";
                    objform.Left = 100;


                    objitem = objform.Items.Add("be_2360",SAPbouiCOM.BoFormItemTypes.it_EDIT);
                    objitem.Left=50;
                    objitem.Left=50;
                    SAPbouiCOM.EditText objedit = (SAPbouiCOM.EditText)objitem.Specific;

                    Button oButton;
                    objitem = objform.Items.Add("btnEntrega", BoFormItemTypes.it_BUTTON);
                    //Inicializando el objeto boton con la referencia del objeto item
                    oButton = (Button)objitem.Specific;
                    //Agregando propiedades al boton
                    oButton.Caption = "Entrega";
                    //agregando posicio del boton
                    objitem.Top = objform.Height - (objitem.Height + 48);
                    objitem.Left = (objitem.Width + 20) + 60;


                    objform.Visible = true;
                    //SBO_Application.MessageBox(objform.u);

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public static void formulario_XML()
        {
            try
            {
                SAPbouiCOM.Form myform;
                SAPbouiCOM.FormCreationParams CreationPackage = (SAPbouiCOM.FormCreationParams)SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
                XmlDocument MyXMLDoc = new XmlDocument();

                string sRutaCompleta = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) + @"\";
                string SRuta = Path.GetDirectoryName(sRutaCompleta);
                MyXMLDoc.Load(SRuta + @"\CrearSN.xml");
                CreationPackage.XmlData = MyXMLDoc.InnerXml;
                myform = SBO_Application.Forms.AddEx(CreationPackage);
                myform.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error General - " + ex.ToString());
            }
        }


      


        public static void SBO_Application_sistema(SAPbouiCOM.BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
                    //Exit Add-On
                    System.Environment.Exit(0);
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
    }
}
