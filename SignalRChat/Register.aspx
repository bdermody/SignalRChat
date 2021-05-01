<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SignalRChat.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
</head>

    <style>

        .wrapper1
        {
            height:100vh !important;
            display:flex;
            align-items:center;
            flex-direction:column;
            justify-content:center;
            width:100% !important;
            padding:20px;
            background-color:#f5f5f5 !important;
        }

        .logincontainer
        {
            border-radius:0px;
            background-color:#fff;
            width:90%; 
            max-width:450px;
            position:relative;
            padding:20px;
            border:1px white solid ;
            box-shadow:0 15px 10px -10px #acacac;
        }

    </style>
<body>
    <form id="form1" runat="server">
        <div class="wrapper1">

           <div class="logincontainer">

                <h3>
                   <img src="Content/add.png" width="50px" height="50px" />  Registro
                </h3>

                <hr />

                <asp:TextBox runat="server" ID="txtUserId" placeholder="Ingrese su usuario nuevo" CssClass="form-control"/>
                <br />

                <asp:TextBox runat="server" ID="txtPassword" placeholder="Ingrese su contraseña"  TextMode="Password" 
                    CssClass="form-control"/>
                <br />

                <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-info form-control" Text="Confirmar"
                    OnClick="InsertUser"  />
                <br />

                
                <asp:Label runat="server" ID="txtInfo" />
              
                  
                
            </div>
        </div>
    </form>
</body>
</html>
