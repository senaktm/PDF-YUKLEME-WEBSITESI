<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_insert.aspx.cs" Inherits="User_insert" %>

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
                <h1>&nbsp;</h1>
                <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Table</h1>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server" Width="995px" HorizontalAlign="Center">
                </asp:GridView>
                <br />
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID TO DELETE &amp; UPDATE :&nbsp;&nbsp;
            <asp:TextBox ID="userID_txt" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; USERNAME :&nbsp;&nbsp;
            <asp:TextBox ID="username_txt" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PASSWORD :&nbsp;&nbsp;
            <asp:TextBox ID="password_txt" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="deleteBtn" runat="server" Text="DELETE" OnClick="deleteBtn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="updateBtn" runat="server" Text="UPDATE" OnClick="updateBtn_Click" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>