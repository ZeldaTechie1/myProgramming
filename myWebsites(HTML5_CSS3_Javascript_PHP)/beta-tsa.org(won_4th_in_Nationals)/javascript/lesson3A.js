var objectid; //stores what you are dragging
			var count = 4;
			function allowDrop(ev)
			{
			ev.preventDefault();
			}
			
			function right(target)
			{
			document.getElementById(target).parentNode.children[1].setAttribute("style","color:green;");
			}
			function wrong(target)
			{
			document.getElementById(target).parentNode.children[1].setAttribute("style","color:red;");
			}
			
			function drag(ev)
			{
			ev.dataTransfer.setData("Text",ev.target.id);
			objectid = ev.target.id;
			}
			//answers 4,1,3,2
			function drop(ev)
			{
			ev.preventDefault();
			var data = ev.dataTransfer.getData("Text");
			var targetid = ev.target.id; //stores where you are dropping the object
				if(targetid == "dropper1")
				{
					if(objectid == "drag4")
					{
						ev.target.appendChild(document.getElementById(data));
						count--;
						right(targetid);
					}
					else{	
						wrong(targetid);
					}
				}
				if(targetid == "dropper2")
				{
					if(objectid == "drag1")
					{
						ev.target.appendChild(document.getElementById(data));
						count--;
						right(targetid);
					}
					else{	
						wrong(targetid);
					}
				}
				if(targetid == "dropper3")
				{
					if(objectid == "drag3")
					{
						ev.target.appendChild(document.getElementById(data));
						count--;
						right(targetid);
					}
					else{	
						wrong(targetid);
					}
				}
				if(targetid == "dropper4")
				{
					if(objectid == "drag2")
					{
						ev.target.appendChild(document.getElementById(data));
						count--;
						right(targetid);
					}
					else{	
						wrong(targetid);
					}
				}
				if(count <=0)
				{
					alert("Congratulations, you have completed this activity!.");
				}
			
			}