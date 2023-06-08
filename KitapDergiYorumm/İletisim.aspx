<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="İletisim.aspx.cs" Inherits="KitapDergiYorumm.İletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <body>

        <div class="contact-content">
            <div class="container">
                <div class="contact-info">
                    <h2>İletişim</h2>
                    <p>Sitemiz içerisinde karşılaştığınız herhangi bir problem olursa lütfen bizlerle iletişime geçin!</p>
                    <div class="contact-details">
                        <form runat="server">
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad" required=""></asp:TextBox>
                            <asp:TextBox ID="TextBox5" runat="server" placeholder="Soyad" required=""></asp:TextBox>
                            <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox></br>
                            <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                            <asp:TextBox ID="TextBox4" runat="server" placeholder="Mesajınız" required="" Height="100" TextMode="MultiLine"></asp:TextBox>

                            <asp:Button ID="Button1" runat="server" Text="GÖNDER" />
                        </form>
                    </div>
                </div>
            </div>
</asp:Content>
