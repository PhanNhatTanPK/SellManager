<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GUI_Web.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style1 {
            width: 71px;
        }
        .auto-style2 {
            margin-left: 95px;
        }
        .auto-style3 {
            width: 587px;
        }
        .auto-style4 {
            width: 198px;
        }
    </style>
</head>
<body style="background-color: #83d8fe;">
    <nav class="navbar navbar-dark bg-dark">
        <ul><li style="color:#ffffff; list-style:none; margin-top:15px;">QUẢN LÝ SINH VIÊN</li></ul>        
    </nav>
    <form id="form1" runat="server" class="row g-3" style="max-width: 900px; margin: auto">
        <div class="row g-3">
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtFullName" runat="server" class="form-control" placeholder="Full Name" style="max-height:50px" />
                  <label for="floatingInput">Full Name</label>
                </div>
            </div>
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtAddress" runat="server" class="form-control" placeholder="Address" style="max-height:50px" />
                  <label for="floatingInput">Address</label>
                </div>
            </div>
        </div>
        <div class="row g-3">
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Email" style="max-height:50px" />
                  <label for="floatingInput">Email</label>
                </div>
            </div>
       </div>           
            <div class="col">   
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">Gender: </td>
                        <td> <asp:RadioButtonList ID="rbGender" runat="server">
                            <asp:ListItem Value="true">Nam</asp:ListItem>
                            <asp:ListItem Value="false">Nữ</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>                      
                    </tr>                  
                </table>
            </div>
        <div>
            <div class="mb-3" style="max-width:870px;">             
              
                <asp:FileUpload ID="FileUpload" class="form-control form-control-sm" runat="server" />
              
            </div>
        </div>
           <div class="row">
                <div class="col">
                    <asp:Button ID="btnAdd" class="btn btn-success" style="padding:5px 30px; margin-left:15px" runat="server" Text="ADD" OnClick="btnAdd_Click"/>
                </div>
                <div class="col">
                    <asp:Button ID="btnEdit" class="btn btn-warning" style="padding:5px 30px; margin-left:15px" runat="server" Text="EDIT" OnClick="btnEdit_Click"/>
                </div>
                <div class="col">
                  <asp:Button ID="btnDelete" class="btn btn-danger" style="padding:5px 30px; margin-left:15px" runat="server" Text="DELETE" OnClick="btnDelete_Click"/>
                </div>
               <div class="col">
                  <asp:Button ID="btnClear" class="btn btn-secondary" style="padding:5px 30px; margin-left:15px" runat="server" Text="Clear" OnClick="btnClear_Click"/>
                </div>
               <div class="col">
                  <asp:Button ID="btnFind" class="btn btn-info" style="padding:5px 30px; margin-left:15px" runat="server" Text="FIND" OnClick="btnFind_Click"/>
                </div>
          </div>   

        <div>
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">   
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" CssClass="auto-style2" Width="716px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                <asp:CheckBoxField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                
                <asp:ImageField DataImageUrlField="ImageUrl" DataImageUrlFormatString="~/images/{0}" HeaderText="Image">
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
                
                <asp:CommandField ShowSelectButton="True" />
                
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
                </td>
                <td class="auto-style3">   
        
                    &nbsp;</td>                
            </tr>            
        </table>
    </form>
</body>
</html>
