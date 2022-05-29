<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GUI_Web.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
</head>
<body class="bg-info">
    <nav class="navbar navbar-dark bg-dark">
        <ul>Home</ul>
        
    </nav>
    <form id="form1" runat="server" class="row g-3" style="max-width: 900px; margin: auto">
        <div class="row g-3">
            <div class="col">
                <div class="form-floating" >
                  <input type="text" class="form-control" placeholder="Full Name" style="max-height:50px" />
                  <label for="floatingInput">Full Name</label>
                </div>
            </div>
            <div class="col">
                <div class="form-floating" >
                  <input type="text" class="form-control" placeholder="Address" style="max-height:50px" />
                  <label for="floatingInput">Address</label>
                </div>
            </div>
        </div>
        <div class="row g-3">
            <div class="col">
                <div class="form-floating" >
                  <input type="email" class="form-control" placeholder="Email" style="max-height:50px" />
                  <label for="floatingInput">Email</label>
                </div>
            </div>
            <div class="col">
                <div class="form-floating" >
                  <input type="email" class="form-control" style="max-height:50px" />
                  <label for="floatingInput">Email address</label>
                </div>
            </div>
            <div class="mb-3">             
              <input class="form-control form-control-sm" id="formFileSm" type="file"/>
            </div>
        </div>
    </form>
</body>
</html>
