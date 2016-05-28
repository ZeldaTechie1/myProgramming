<!DOCTYPE html>
<head>
<meta charset="UTF-8">
<title>Try It Yourself</title>
<link rel="shortcut icon" href="images/faviTCZ.png" type="image/png"> 
<link rel="icon" href="images/faviTCZ.png" type="image/png">
<link rel="stylesheet" href="css/style.css" type="text/css" media="screen">
<script src="//tinymce.cachefly.net/4.0/tinymce.min.js">
</script>
<script>
tinymce.init({selector:'textarea#input', toolbar: 'outdent | indent', menubar:false, statusbar: false,content_css:"css/tinymce.css"});
</script>
		<script type = "text/javascript">


			var isSelected1 = false;
			

			function toggle2()
			{

				if(!isSelected1)
				{
					document.getElementById("betatsa").style.display="block";
					isSelected1 = true;

					
				}
				else
				{
					document.getElementById("betatsa").style.display="none";
					isSelected1 = false;
				}
			}


			function tug()
			{

				document.getElementById("betatsa").style.display="none";
				
				isSelected1 = false;
				

			}
			function data_submit()
			{
				
				var plainText = tinyMCE.activeEditor.getBody().textContent; 
            			document.form1.txt_data.value = plainText;	
				
			}

		</script>

<style type="text/css">
	.trytable
	{
	 background-color:#000033;
	}
	.out
	{
	text-align:center; 
	color:white;
	font-size:30px;
	}
	.codetype
	{
	resize: none;
	width:500px; 
	height:550px; /*here*/
	border:0px;
	background-color:#000033;
	color:white;
	}	
	.render
	{
	margin-top:10px;
	background-color:white;
	height:585px; /*here*/
	width:500px;
	border:0px;
	border-top:15px solid #000033; 
	}
	#idk
	{
	height:0px;
	width:0px; 
	border:0px; 
	visibility:hidden;
	}
	.butt
	{
	font-size:20px;
	}
	
	</style>
</head>

<body>


<div class="header" style="height:125px;">

<a href = "lesson1V.html"><img src="images/thecodezonelogo.png" class="logo" alt="BETA TSA Logo" id="Z" style="z-index:5; width:1000px; height:100px; margin-top:0px;"></a>
    <div class="menu" >
        <div class="span" style = "float:left; margin-top:20px; margin-bottom:-10px; border-bottom:5px solid #0099cc; border-top:5px solid #0099cc; height:40px; width:1000px;  margin-bottom:10px;">
            <ul id="nav">
                <li style = "margin-right:113px; margin-top:-8px;">
		<a  href="thecodezone.html" onclick = "toggle1();" style = "font-size:20pt; height:30px; padding-bottom:10px; ">Home</a>
		</li>
                <li style = "margin-right:113px; margin-top:-8px;"><a  href="#"  onclick = "toggle2();" style = "font-size:20pt">Tutorials</a>
    			<div class="subs">
                        	<div id="betatsa"  style="margin-left:25px;">
                            	<ul>
                                	<li>
                                   	 <ul>
						<li><a href="lesson1V.html">Get Ready!</a></li>
						<li><a href="lesson2V.html">HTML5</a></li>
                                        	<li><a href="lesson3V.html">Tags</a></li>
                                        	<li><a href="lesson4V.html">Block Level</a></li>
                                        	<li><a href="lesson5V.html">Text Level</a></li>
                                        	<li><a href="lesson6V.html">Links</a></li>
                                        	<li><a href="lesson7V.html">CSS3</a></li>
                                        	<li><a href="lesson8V.html">Comments</a></li>
                                        	<li><a href="lesson9V.html">Images</a></li>
                                        	<li><a href="lesson10V.html">Structure</a></li>
                                    	</ul>
                                	</li>
                            	</ul>
                        	</div>
                    	</div>
		</li> 
		<li style = "margin-right:113px; margin-top:-8px;" ><a href="tryit.php" style = "font-size:20pt" class="on">Try It</a></li>
		<li style = "margin-right:90px; margin-top:-8px;"><a href="about.html" style = "font-size:20pt">CTE</a></li>
		<li><a href="aboutus.html" style = " position:absolute; font-size:20pt; margin-top:-8px; width:130px; text-align:right;">About Us</a></li>
            </ul>
        </div>
    </div>



</div>

<br/>

<!--Jesus Code-->

<div class = "contenttry" onclick="tug();">
		
		<form name="form1" id="form1" method="post" action="tryit.php" >
			<table class="trytable">
				<tr>
					<td> 
					<input type="submit" name="bt_submit" value="Submit Code" onClick="data_submit();" class="butt"/>
					</td>
					<td class="out">Output</td>
				</tr>
				<tr>
					<td class="codetype">
					<input type="text" id="idk" name="txt_data" value=""/>
						
       <textarea id = "input" class="codetype" name="txt_html"><?php if(!empty($_POST['txt_html']))
							{
							//echo trim($content);
							echo htmlentities($_POST['txt_html']);
							}
							else
							{
								$input = '&lt;!DOCTYPE html&gt;<br/>&lt;html&gt;<br/>&lt;head&gt;<br/>&lt;!--TYPE IN YOUR CSS IN THE STYLE TAGS--&gt;<br/>&lt;style&gt;<br/> body<br/>{ <br/>background-color:grey; <br/>color:white; <br/>}<br/>&lt;/style&gt;<br/>&lt;/head&gt;<br/>&lt;body&gt;<br/>&lt;h1&gt;Hello World!!!&lt;/h1&gt;<br/>&lt;/body&gt;<br/>&lt;/html&gt;';
								$input = htmlentities($input);
								echo $input;
							} ?>
						</textarea>
					</td>
					<td>
					<?php
						//echo '<iframe class="render" src="'.$newfile.'" name="iframe_a"></iframe>';
//						<iframe class="render" src="" name="iframe_a"></iframe>
						
						if(!empty($_POST['txt_data']))
						{
						$count = 0;
						$default = "try_it.php";
						$wfile = "try_it".$count.".php";
						while(file_exists($wfile))
						{
						$count++;
						$wfile = "try_it".$count.".php";
						}
						$file  = fopen($wfile,'w');
						fwrite($file, html_entity_decode($_POST['txt_data']));
						fclose($file);
						echo '<iframe class = "render" src="'.$wfile.'"></iframe>';
						}
						else
						{
						echo '<iframe class = "render" src="try_it.php"></iframe>';
						}
					?>
					</td>
				</tr>
			</table>
		</form>
		
<!--Jesus Code-->
</div>


<div class="backStripM">.</div>
<div class="strip">.</div>

<div class="footer" onclick ="tug();">

<a href="http://instagram.com/beta_tsa"><img src="images/instagram.png" class="share" alt="Instagram Icon" id="inst"></a>
<a href="https://twitter.com/betatxtsa"><img src="images/twitter.png" class="share" alt="Twitter Icon" id="twit"></a> 
<a href="https://www.facebook.com/groups/89143845409/"><img src="images/facebook.png" class="share" alt="Facebook Icon" id="face"></a>

</div>

<div style = "text-align:center; width:500px; margin-left:auto; margin-right:auto;margin-top:-40px; color:white;" ><b>Business Education Technology Academy</b> 2014. <i>All Rights Reserved</i>.</div>
<br/>
<div style = "text-align:center;width:1000px; margin-left:auto; margin-right:auto; margin-top:-25px;" ><a href = "sitemap.html" class="sitemaplink"><h3>Site Map</h3></a></div>





</body>

</html>