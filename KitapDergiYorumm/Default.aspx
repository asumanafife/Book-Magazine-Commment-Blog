<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KitapDergiYorumm.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img src= "<%#Eval ("BLOGGORSEL")%>" "alt="" 
                                    style= height:500px; width:250px"/>
                                <div class="post-info">
                                    <h4><a href="BlogDetay.aspx?BLOGID=<%# Eval("BLOGID") %>"><%#Eval("BLOGBASLIK") %></a> <%# Eval ("BLOGTARIH") %></h4>
                                    <p><%#Eval ("BLOGICERIK")%></p>
                                    <a href="single.html"><span></span>Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>SON BLOGLAR</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%#Eval("BLOGBASLIK")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                        
                        
                    </ul>
                </div>
                
                <div class="clearfix"></div>
                <div class="archives">
                    <h3>ARŞİVLER</h3>
                    <ul>
                        <li><a href="#">Nisan 2023</a></li>
                        <li><a href="#">Haziran 2023</a></li>
                       
                    </ul>
                </div>
                <div class="categories">
                    <h3>KATEGORİLER
                    </h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%#Eval("KATEGORIAD")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                        
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>



</asp:Content>
