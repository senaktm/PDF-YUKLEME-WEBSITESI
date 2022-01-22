<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
    <link

    href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    
    
</head>
<body>
     <nav class ="navbar navbar-expand navbar-dark bg-dark">
     <div class ="container-fluid">
         <button 
         class ="navbar-toggler" 
         type ="button" 
         data-bs-toggle ="collapse"
         data-bs-target="#navbar"
         >
         <span class="navbar-toggler-icon"></span>
         </button>
         <div class="collapse navbar-collapse" id ="navbar">
             <div class ="navbar-nav">
                 <a class="nav-item nav-link" href="Home.aspx">Home</a>
                 <a class="nav-item nav-link" href="PDF_search.aspx">PDF SEARCH</a>
                 <a class="nav-item nav-link" href="User_insert.aspx">USER_INFO</a>

             </div>
         </div>
     </div>   
    </nav>

    <form id="form1" runat="server">
        <div>
            WELCOME
            <asp:Label ID="nameLbl" runat="server" Text="[nameLbl]"></asp:Label>
        </div>
    </form>
</body>
</html>
