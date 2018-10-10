﻿Computer Science A
2A
Due Sep 18, 5:00 PM
Project 3: Create Robotics Home Page

Doug Benton
Sep 12 (Edited Sep 12)
Create a static web page to act as a the landing site for anyone interested in the Jerome Robotics Club. Use the Codebrainery.io page that you created in Project 2 as a template.

Project3_CreateRoboticsHomepage
Google Docs
Your work
Turned in late

jaces index.html
HTML

style.css
Style Sheet

﻿body {
  font-family: 'Roboto', sans-serif;
}

ul {
  list-style: none;
  display: flex;
  justify-content: flex-end;
}

figure img {
  width: 100%;
  height: auto;
}

figure {
  margin-bottom: 30px;
}

header nav {
  display: flex;
  justify-content: flex-end;
}

div > h1 {
  font-size: 1.8rem;
}

nav > p {
  cursor: pointer;
}
.pill-black, .pill-white {
  border: 0.5px solid;
  border-radius: 5px;
  text-align: center;
}

.pill-black {
  background-color: #000000;
  color: #FFFFFF;
}

footer {
  margin-top: 20px;
}

footer div {
  display: flex;
  align-items: center;
}

/* Customizations of Bootstrap classes */

header .row {
  display: flex;
  align-items: center;
}

.col-sm-4 p {
  margin: 25px 20px 15px;
  min-width: 60px;
  padding: 1px;
}

section.container .row {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
}

.jumbotron {
  display: flex;
  align-items: center;
  height: 350px;
  background-image: url("https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2018/universe.jpg");
  background-size: cover;
  background-position: center;
}

.jumbotron h2 {
  background-color: #FFFFFF;
  display: inline-block;
  color: #F06529;
  font-weight: 700;
  padding: 10px 35px;
  border-radius: 5px;
}

.jumbotron h3 {
  color: #FFFFFF;
  font-weight: bold;
}

.btn-primary {
  color: #2e6da4;
  background-color: #FFFFFF;
}

.col-sm-1 img {
  min-width: 32px;
  min-height: 33px;
}
style.css
Displaying jaces index.html.