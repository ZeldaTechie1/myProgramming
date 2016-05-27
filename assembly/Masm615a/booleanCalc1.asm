;Create a program that functions as a simple boolean calculator for 32-bit integers. 
;It should display a menu that asks the user to make a selection from the following list: 
;1.x AND y 2.x OR y 3.NOT x 4.x XOR y 5.Exit program 
;When the user makes a choice, call a procedure that displays the name of the operation about to be performed. 
;You must implement this procedure using the Table-Driven Selection technique, shown in Section 6.5.4.

.386
.MODEL flat, stdcall
.STACK 4096
ExitProcess PROTO, dwExitCode:DWORD

INCLUDE INCLUDE\Irvine32.inc

.DATA
	CaseTable BYTE '1'
		DWORD A_N_D
	EntrySize = ($ - CaseTable) 
		BYTE '2'           
		DWORD O_R        
		BYTE '3'           
		DWORD N_O_T         
		BYTE '4'           
		DWORD X_O_R
		BYTE '5'
		DWORD E_X_I_T
	NumberOfEntries = ($ - CaseTable) / EntrySize
	
	prompt BYTE "1:x AND y ||| 2:x OR y ||| 3:NOT x ||| 4:x XOR y ||| 5:Exit program ",0
	
	msgAND BYTE "AND Operation Selected",0 
	msgOR BYTE "OR Operation Selected",0 
	msgNOT BYTE "NOT Operation Selected",0 
	msgXOR BYTE "XOR Operation Selected",0
	msgEXIT BYTE "EXIT Operation Selected",0
.CODE
	main PROC
		;ask for input
		mov edx, OFFSET prompt 
		call writeString
		
		;read input
		call ReadChar
		call crlf
		
		mov ebx, OFFSET CaseTable ;start reading Case table
		mov ecx, NumberOfEntries ;set loop counter
		
		FINDMATCH:
			cmp al, [ebx] ;check for match with casetable
			jne NO 
			
			call NEAR PTR [ebx+1] ;check what is right after the lookup value
			call writeString ;write the string that correlates with lookup value
			call crlf ;new line
			jmp DONE
		;if no match then move to next location on table
		NO:
			add ebx, EntrySize
			loop FINDMATCH
		DONE:
		
		;delay so you can see output on execution
		mov eax, 5000
		call delay

		INVOKE ExitProcess, 0
	main ENDP
	
	A_N_D PROC
		MOV EDX, OFFSET msgAND
		RET
	A_N_D ENDP
	
	O_R PROC
		MOV EDX, OFFSET msgOR
		RET
	O_R ENDP
	
	N_O_T PROC
		MOV EDX, OFFSET msgNOT
		RET
	N_O_T ENDP
	
	X_O_R PROC
		MOV EDX, OFFSET msgXOR
		RET
	X_O_R ENDP
	
	E_X_I_T PROC
		MOV EDX, OFFSET msgEXIT
		RET
	E_X_I_T ENDP

END main



