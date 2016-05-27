;reverses the string in source and places it into target
;By: Bryan Cancel

.386
.MODEL flat, stdcall
.STACK 4096
ExitProcess PROTO, dwExitCode:DWORD

INCLUDE INCLUDE\Irvine32.inc

.DATA
	;this specific program requires byte source and target
	source BYTE "This is the source string",0
	target BYTE SIZEOF source DUP('#')
.CODE
	main PROC
		mov esi, OFFSET source 	;create pointer to source
		add esi, SIZEOF source 	;shift source pointer to back of source
		dec esi 			   	;ignore the null termiating symbol
		mov edi, OFFSET target 	;set the edi to point to the first locaion on the target
		mov ecx, SIZEOF source  ;set the time the loop will run
		
		L1:
			mov al, [esi]
			mov [edi], al ;set the first location of target with last location in source
			dec esi ;go to next location in source
			inc edi ;go to next location in target
			loop L1
		
		;add null terminator for target
		inc edi
		mov al, 0
		mov [edi], al
		
		;Visually print the old and then new string
		mov edx, OFFSET source ;caption
		call writestring
		
		call crlf
		
		mov edx, OFFSET target ;caption
		inc edx
		call writestring
		
		call crlf
		
		;delay 5 seconds
		mov eax, 5000
		call delay
		

		INVOKE ExitProcess, 0
	main ENDP
END main



