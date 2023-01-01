<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxTutorial.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #loader{
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type= "text" placeholder= "Enter your name" id= "uname" />
            <br /> <br />
            <input type= "text" placeholder= "Enter your surname" id= "suruname" />
            <br /> <br />
            <input type= "button" value= "Submit" id= "btn" />
            <br />
            <h2 id="result"></h2>
            <div id="loader">
                <img src="images/loader.png" height="100" />
            </div>
        </div>
    </form>
    <script src="scripts/jquery-3.6.3.min.js"></script>
    <script>
const { error } = require("jquery");

        $(document).ready(function () {
            $('#btn').click(function () {
                var uname = $('#uname').val();
                var surname = $('#surname').val();
                if (uname == "" || surname == "")
                {
                    alert("Fill all the fields");
                }
                else
                {
                    $.ajax({
                        url: 'WebForm1.aspx/getData',
                        type: 'post',
                        contentType: 'application/json',
                        data: JSON.stringify({ uname: uname, surname: surname }),
                        dataType: 'json',
                        beforeSend: function () {
                            $('#loader').show();
                        },
                        success: function (result, status, xhr) {
                            $('#result').text(result.d);
                        },
                        error: function (xhr, status, result) {
                            alert(xhr);
                            alert(status);
                            $('#result').text(result.d);
                        },
                        complete: function (xhr, status) {
                            alert(status);
                        }
                    });
                }
            });
        });
    </script>
</body>
</html>
