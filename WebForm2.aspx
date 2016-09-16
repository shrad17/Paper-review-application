<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SAM2017.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
<form action="action_page.php">
  <fieldset>
    <legend>Paper Submission</legend>
    Upload File:<br>
    <input type="text" name="Add" >
    <br>
    <br><br>
    <input type="submit" value="Add">
  </fieldset>
<br>
     Paper Title:<br>
    <input type="text" name="Paper Title" >
    <br>
 <fieldset> 
  <input type="radio" name="New Submission" checked>New Submission
  <br>
  <input type="radio" name="Revision 1" >Revision 1
   <br>
  <input type="radio" name="Revision 2" >Revision 2
</fieldset>
</form>

  