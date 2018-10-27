<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebECETest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style2 {
            width: 234px;
        }
        .auto-style3 {
            background-color: #FFCC00;
        }
        .auto-style4 {
            background-color: #99FF33;
        }
        .auto-style5 {
            background-color: #FF9900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div dir="rtl">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
        <asp:Label ID="Label12" runat="server" Text="موضوع نامه"></asp:Label>
        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label11" runat="server" Text="شماره نامه"></asp:Label>
        <asp:TextBox ID="txtLetterNo" runat="server"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label10" runat="server" Text="تاریخ نامه"></asp:Label>
        <asp:TextBox ID="txtLetterDate" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="Label32" runat="server" Text="نوع تاریخ"></asp:Label>
                    <asp:DropDownList ID="drpDateType" runat="server">
                        <asp:ListItem Value="gregorian" Selected="True">میلادی</asp:ListItem>
                        <asp:ListItem Value="jalali">هجری شمسی</asp:ListItem>
                        <asp:ListItem Value="hijri">هجری قمری</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:Label ID="Label9" runat="server" Text="الویت"></asp:Label>
                    <asp:DropDownList ID="drpLetterPriority" runat="server">
                        <asp:ListItem Value="1" Selected="True">عادی</asp:ListItem>
                        <asp:ListItem Value="2">فوری</asp:ListItem>
                        <asp:ListItem Value="3">خیلی فوری</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
        <asp:Label ID="Label8" runat="server" Text="طبقه بندی"></asp:Label>
                    <asp:DropDownList ID="drpLetterClassification" runat="server">
                        <asp:ListItem Value="1" Selected="True">عادی</asp:ListItem>
                        <asp:ListItem Value="2">محرمانه</asp:ListItem>
                        <asp:ListItem Value="3">خیلی محرمانه</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>کلید وازه<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style5">اصل نامه </td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label14" runat="server" Text="عنوان فایل"></asp:Label>
        <asp:TextBox ID="txtOriginFileDesc" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="Label30" runat="server" Text="نوع فایل"></asp:Label>
                    <asp:DropDownList ID="drpOriginFileType" runat="server">
                        <asp:ListItem Selected="True">image/jpeg</asp:ListItem>
                        <asp:ListItem>image/tiff</asp:ListItem>
                        <asp:ListItem>image/gif</asp:ListItem>
                        <asp:ListItem>image/png</asp:ListItem>
                        <asp:ListItem>application/msword</asp:ListItem>
                        <asp:ListItem>application/pdf</asp:ListItem>
                        <asp:ListItem>text/plain</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="مسیر فایل"></asp:Label>
                    <asp:FileUpload ID="upldFilePath" runat="server" />
                    <asp:Button ID="btnAddOrginLetter" runat="server" Text="اضافه" Enabled="False" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center; background-color: #9900FF;">پیوست های نامه</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label21" runat="server" Text="عنوان فایل"></asp:Label>
        <asp:TextBox ID="txtAttchFileDesc" runat="server"></asp:TextBox>
        <asp:Label ID="Label31" runat="server" Text="نوع فایل"></asp:Label>
                    <asp:DropDownList ID="drpAttachmentFileType" runat="server">
                        <asp:ListItem Selected="True">image/jpeg</asp:ListItem>
                        <asp:ListItem>image/tiff</asp:ListItem>
                        <asp:ListItem>image/gif</asp:ListItem>
                        <asp:ListItem>image/png</asp:ListItem>
                        <asp:ListItem>application/msword</asp:ListItem>
                        <asp:ListItem>application/pdf</asp:ListItem>
                        <asp:ListItem>text/plain</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="مسیر فایل"></asp:Label>
                    <asp:FileUpload ID="upldAttachFilePath" runat="server" />
                    <asp:Button ID="btnAddAttachLetter" runat="server" Text="اضافه" Enabled="False" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style3">دریافت کننده</td>
                <td style="text-align: center" class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:Label ID="Label23" runat="server" Text="نام و نام خانوادگی"></asp:Label>
        <asp:TextBox ID="txtReceiverName" runat="server"></asp:TextBox>
                </td>
                <td>پست سازمانی<asp:TextBox ID="txtReceiverPosition" runat="server" Width="88px"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label24" runat="server" Text="سازمان"></asp:Label>
        <asp:TextBox ID="txtReceiverOrg" runat="server" Width="135px"></asp:TextBox>
        &nbsp;<asp:Label ID="Label28" runat="server" Text="دپارتمان"></asp:Label>
        <asp:TextBox ID="txtReceiverDepartment0" runat="server"></asp:TextBox>
        &nbsp; کد
        <asp:TextBox ID="txtReceiverCode" runat="server" Width="35px"></asp:TextBox>
        &nbsp;نوع دریافت نامه
                    <asp:DropDownList ID="drpReceiverType" runat="server">
                        <asp:ListItem Selected="True" Value="1">اصل</asp:ListItem>
                        <asp:ListItem Value="2">رونوشت</asp:ListItem>
                        <asp:ListItem Value="3">ارجاء</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center; background-color: #FF00FF;">رونوشت های نامه</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:Label ID="Label25" runat="server" Text="نام و نام خانوادگی"></asp:Label>
        <asp:TextBox ID="txtOtherReceiverName" runat="server"></asp:TextBox>
                </td>
                <td>پست سازمانی<asp:TextBox ID="txtOtherReceiverPosition" runat="server" Width="80px"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label26" runat="server" Text="سازمان"></asp:Label>
        <asp:TextBox ID="txtOtherReceiverOrg" runat="server"></asp:TextBox>
        &nbsp;&nbsp;<asp:Label ID="Label27" runat="server" Text="دپارتمان"></asp:Label>
        <asp:TextBox ID="txtOtherReceiverDepartment" runat="server"></asp:TextBox>
                    &nbsp;&nbsp; کد
        <asp:TextBox ID="txtOtherReceiverCode" runat="server" Width="40px"></asp:TextBox>
        &nbsp;نوع دریافت نامه
                    <asp:DropDownList ID="drpOtherReceiverType" runat="server">
                        <asp:ListItem Value="1">اصل</asp:ListItem>
                        <asp:ListItem Selected="True" Value="2">رونوشت</asp:ListItem>
                        <asp:ListItem Value="3">ارجاء</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnAddOtherReceiver" runat="server" OnClick="btnAddOtherReceiver_Click" Text="اضافه کردن رونوشت" Width="91px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style4">اطلاعات فرستنده</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:Label ID="Label18" runat="server" Text="نام و نام خانوادگی"></asp:Label>
        <asp:TextBox ID="txtSenderName" runat="server"></asp:TextBox>
                </td>
                <td>پست سازمانی<asp:TextBox ID="txtSenderPosition" runat="server"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label20" runat="server" Text="سازمان"></asp:Label>
        <asp:TextBox ID="txtSenderOrg" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label29" runat="server" Text="دپارتمان"></asp:Label>
        <asp:TextBox ID="txtSenderDepartment0" runat="server"></asp:TextBox>
        &nbsp;کد
        <asp:TextBox ID="txtSenderCode" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnCreateECE" runat="server" Text="تولید فایل ECE" OnClick="btnCreateECE_Click" />
                    <asp:Button ID="btnLoadEceXml" runat="server" OnClick="btnLoadEceXml_Click" Text="load Ece xml" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
