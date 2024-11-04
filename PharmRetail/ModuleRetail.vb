Module ModuleRetail

    '##Database Conn
    Public connections As String = ""
    Public db_password As String = ""
    Public db_servername As String = ""
    Public db_databasename As String = ""
    Public strPrinterName As String = ""
    Public strStoreName As String = ""
    Public loggedIn As String = ""
    Public db_username As String = ""
    Public db_passwd As String = ""
    Public main_FilePath As String = "C:\PharmRetail\"
    '##Database Conn

    Public msgbox_header As String = "Retail - Version 1.0.0.0"


    '##Log Details
    Public user_code As String = ""
    Public user_name As String = ""
    Public user_store As String = ""
    Public user_till As String = ""
    Public user_fullName As String = ""
    Public user_LoginId As Integer = 0
    Public user_group As String = ""
    Public user_groupII As String = ""
    Public user_groupIII As String = ""
    Public user_id As String = ""
    Public user_no As Integer = 0
    Public str_salt As String = "_646@@###***HHM**63672018"
    Public user_groupNo As String = ""
    Public record_id As String = ""
    Public positionCode As String = ""
    Public selected_itemValue As String = ""
    Public session_Id As String = ""
    Public suppcat_Option As String = ""
    Public supp_Id As String = ""
    Public retailStore As String = ""
    Public crypt_saltedpassword As String = Nothing
    Public plain_password As String = Nothing
    Public Is_userActive As String = "N"
    Public group_id As String = ""
    Public selected_ageId As String = ""
    Public selected_ageName As String = ""
    Public selected_itemCode As String = ""
    Public admindosage_func As String = ""
    Public lookup_itemCode As String = ""
    Public lookup_itemName As String = ""
    Public ibt_Number As String = ""
    Public ibt_PrintCode As String = ""
    '##Log Details


    Public Isfile_headerp As Boolean = True
    Public save_next As Boolean = False
    Public isdb_Conn As Boolean = False
    Public hse_no As String = ""
    Public search_Option As String = ""
    Public acc_Option As String = ""
    Public search_Filter As String = ""
    Public currFileDate As String = ""
    Public deleting As Boolean = True
    Public acc_id As String = ""
    Public column_header As String = ""
    Public search_Code As String = Nothing
    Public company_Id As String = "999"
    Public printer_Type As String = Nothing
    Public printer_Name As String = Nothing
    Public sale_Code As String = Nothing
    Public sale_ItemCode As String = Nothing
    Public IsItemCode_Change As Boolean = False


    '##Store Details
    Public storeName As String = ""
    Public storeCode As String = ""
    Public storeAddress As String = ""
    Public storePostalCode As String = ""
    Public storePhone As String = ""
    Public storeEmail As String = ""
    Public storeWebsite As String = ""
    Public selectstore_Flag As String = ""
    '##Store Details


    '##Other Details
    Public strmaster_code As String = Nothing
    Public strmaster_price As Double = 0
    Public strmaster_discount As Double = 0
    Public strmaster_taxcode As String = Nothing
    Public strsale_code As String = Nothing
    Public strsale_voiditem As Boolean = False
    Public sale_itemcount As Integer = 0
    Public sale_itemdiscount As Double = 0
    Public cashsale_Status As String = "S"
    Public pos_MoreFns As String = Nothing
    '##Other Details

    '##Select Strings
    Public show_HSaleCustomerSearch_String As String = "SELECT dbo.ToProperCase(custo_fullname)," _
    & "custo_phcode+ ' ' + custo_phno as custo_phno"
    Public show_PoSHeldSale_String As String = "SELECT  sale_refno FROM pos_heldsale"
    Public show_PoSHeldSaleCus_String As String = "SELECT  sale_cusname,sale_cusphone FROM pos_heldsale"
    Public show_PoSItemlookup_String As String = "SELECT  master_code,master_saledescrip,master_uom,master_price" _
    & " FROM pos_stockmaster"
    Public show_PoSUnHoldSaleCustomer_String As String = "SELECT  sales_refno FROM pos_sale"
    '##Select Strings


End Module
