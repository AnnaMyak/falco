<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="FALCO.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


     <div class="form">
        <form id="form1" runat="server" enctype="multipart/form-data">
            <h3>Данные заказчика</h3>
            <div class="data">
                <div>
                    <label>Organ</label>
                    <input name="Organ" />
                </div>
                <div>
                    <label>Tissue</label>
                    <input name="Tissue" />
                </div>
                <div>
                    <label>Stain</label>
                    <input name="Stain" />
                </div>
                <div>
                    <label>Value</label>
                    <input name="Value" />
                </div>
                <input type="submit" value="Вставить в БД" />
            </div>
        </form>
    </div>

    <style>
        .form { position: absolute; left: 50%; width: 470px; margin-left: -235px; background: #888; border-radius: 5px; top: 20px; }
        form { background: #fff; border-radius: 2px;  margin: 5px;  }
        .data { border-top: 1px solid #d5d5d5; padding: 10px 15px; }
        .data div { margin: 8px 0; }
        h3 { padding: 10px 15px; margin: 0; }
        label { min-width: 100px; display: block; float: left; }
        input[type="submit"] { margin-top: 10px; }
    </style>
</body>


</html>
