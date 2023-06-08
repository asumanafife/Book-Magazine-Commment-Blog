﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage.aspx" %>

<!DOCTYPE html>
<html lang="tr">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Interactive login page</title>
  <link rel="stylesheet" href="./index.css">
</head>
<style>
</style>
<body>
  <div class="main-wrapper">
    <div class="monkey-thought">
      <div class="buble-1"></div>
      <div class="monkey-comment">
        <p>is it a email?</p>
      </div>
    </div>
    <div class="img-wrapper">
      <div class="monkey-face">
        <img src="./Images/monkey.png" alt="face">
        <div class="eyes-wrapper">
          <div class="eyes">
            <div class="eye-brow"></div>
            <div class="eye-ball"></div>
          </div>
          <div class="eyes">
            <div class="eye-brow"></div>
            <div class="eye-ball"></div>
          </div>
        </div>
      </div>
      <img class="monkey-hand" src="./Images/hand.png" alt="hand">
    </div>
    <form runat="server">
      <input type="email" id="email" placeholder="john@gmail.com" autocomplete="off" required>
      <input type="password" placeholder="password" id="password"  onfocus="showMonkeyHand()" required>
      <a href="/AdminSayfalar/Bloglar.aspx" style="background-color: #00aeff;color: white;padding: 20px 20px;border-radius: 5px;">Giriş</a>
    </form>
  </div>
</body>
  <script src="./index.js"></script>
</html>
