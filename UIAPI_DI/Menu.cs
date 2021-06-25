using System;
using System.Collections.Generic;
using System.Text;
using SAPbouiCOM.Framework;

namespace UIAPI_DI
{
    class Menu
    {
        public void AddMenuItems()
        {
            SAPbouiCOM.Menus oMenus = null;
            SAPbouiCOM.MenuItem oMenuItem = null;

            oMenus = Application.SBO_Application.Menus;

            SAPbouiCOM.MenuCreationParams oCreationPackage = null;
            oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));
            oMenuItem = Application.SBO_Application.Menus.Item("43520"); // moudles'

            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
            oCreationPackage.UniqueID = "UIAPI_DI";
            oCreationPackage.String = "UIAPI_DI";
            oCreationPackage.Enabled = true;
            oCreationPackage.Position = -1;

            oMenus = oMenuItem.SubMenus;

            try
            {
                //  If the manu already exists this code will fail
                oMenus.AddEx(oCreationPackage);
            }
            catch (Exception e)
            {

            }

            try
            {
                // Get the menu collection of the newly added pop-up item
                oMenuItem = Application.SBO_Application.Menus.Item("UIAPI_DI");
                oMenus = oMenuItem.SubMenus;

                // Create s sub menu
                oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                oCreationPackage.UniqueID = "UIAPI_DI.Form1";
                oCreationPackage.String = "Form1";
                oMenus.AddEx(oCreationPackage);


                oMenuItem = Application.SBO_Application.Menus.Item("UIAPI_DI");
                oMenus = oMenuItem.SubMenus;

                // Create s sub menu
                oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                oCreationPackage.UniqueID = "UIAPI_DI.grilla";
                oCreationPackage.String = "Socio Negocio";
                oMenus.AddEx(oCreationPackage);
            }
            catch (Exception er)
            { //  Menu already exists
                Application.SBO_Application.SetStatusBarMessage("Menu Already Exists", SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }
        }

        public void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                if (pVal.BeforeAction && pVal.MenuUID == "UIAPI_DI.Form1")
                {
                    Form1 activeForm = new Form1();
                    activeForm.Show();
                }
                if (pVal.BeforeAction && pVal.MenuUID == "UIAPI_DI.grilla")
                {
                    //Grilla activeForm = new Grilla();
                    Prueba activeForm = new Prueba();
                    //activeForm. 
                   
                    activeForm.Show();
                }

            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.ToString(), 1, "Ok", "", "");
            }
        }

    }
}
