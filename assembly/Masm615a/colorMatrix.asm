;Write a program that displays a single character in all possible combinations of foreground and background colors (16 * 16 = 256). 
;The colors are numbered from 0 to 15, so you can use a nested loop to generate all possible combinations
;By: Bryan Cancel

.386
.MODEL flat, stdcall
.STACK 4096
ExitProcess PROTO, dwExitCode:DWORD

INCLUDE INCLUDE\Irvine32.inc

.DATA
	testString BYTE "00",0
.CODE
	main PROC
	
		mov ecx, 16 ;set te loop to run 16 times
		mov edi, 15 + (15 * 16) ;holds the first color combo
		ROW:
			mov ebx, ecx ;save our current ecx
			mov ecx, 16 ;set the loop to run 16 times
			COL:
				;set foreground and background color (ebx and ecx) respectively
				mov eax, edi
				call setTextColor
				
				;output the text with the appropiate foreground and background color
				mov eax, 0
				call writeDec
				
				dec edi	;to move on to next color combo			
			LOOP COL
			call crlf ;go to the next line
			mov ecx, ebx ;give the loop counter back to the outer loop
		LOOP ROW
		
		;retrun back to our regular colors
		mov eax, 15 + (0 * 16)
		call setTextColor
		
		;delay 5 second for the executable
		mov eax, 5000
		call delay

		INVOKE ExitProcess, 0
	main ENDP
END main



