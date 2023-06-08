<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGüncelle.aspx.cs" Inherits="KitapDergiYorumm.AdminSayfalar.YorumGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <form runat="server" class="form-group">

        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" placeholder="Yorum İçerik" Height="100px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
         

    </form>

</asp:Content>
