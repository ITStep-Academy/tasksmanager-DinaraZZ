<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="WebApplication4.Task" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <form action="get" runat="server">
        <div id="myDIV" class="header">
            <h2>My To Do List</h2>
            <asp:TextBox ID="newTask" runat="server" placeholder="Text..."></asp:TextBox>
            <%--<input type="text" name="newTask" placeholder="Title...">--%>
            <%--<button type="submit" class="addBtn">Add</button>--%>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
    </form>

    <ul id="myUL">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                    <div class="task">
                        <%# Eval("Title") %>
                    </div>
                    <div class="action">
                        <a href="#"><i class="fa fa-edit"></i></a>
                    </div>
                    <div class="action">
                        <a href="#"><i class="fa fa-trash-alt"></i></a>
                    </div>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
