<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index3.aspx.cs" Inherits="Övning30webforms.index3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/jquery-3.0.0.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <script>
        $(function(){
            //alert('Jquery is working');
            $("#myButton").click(function () {
                 $.get("/svc/contact.aspx")
                .done(function (data) {

                    var myJSON = JSON.parse(data);

                    for (var i = 0; i < myJSON.length; i++) {
                        $("#tableBody").append("<tr><td>" + myJSON[i].ID + "</td><td>" + myJSON[i].FirstName + "</td></tr>");
                    }
                });
            });
            $("#firstnameButton").click(function () {
                var textvalue = $("#firstName").val();
                var textvaluelastname = $("#lastName").val();
                var textvaluessn = $("#ssn").val();
                $.get("/svc/contact.aspx" + "?action=addcontact&firstname=" + textvalue + "&lastname=" + textvaluelastname + "&ssn=" +textvaluessn)
                    .done(function (data) {
                        alert(data);
                    });
            });
           
        });
    </script>

    <table id="tableBody">
        <tr>
            <th>ID</th>
            <th>Firstname</th>
        </tr>
    </table>
    <input type="button" value="Click me" id="myButton"/>
    <br />
    Firstname: <input type="text" id="firstName" />
    Lastname: <input type="text" id="lastName" />
    SSN: <input type="text" id="ssn" />
    <input type="button" value="Tryckhär!!!" id="firstnameButton" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
