;Continue the solution program from Exercise 5 by implementing the following procedures: 
;AND_op: Prompt the user for two hexadecimal integers. AND them together and display the result in hexadecimal.
;OR_op: Prompt the user for two hexadecimal integers. OR them together and display the result in hexadecimal. 
;NOT_op: Prompt the user for a hexadecimal integer. NOT the integer and display the result in hexadecimal. 
;XOR_op: Prompt the user for two hexadecimal integers. Exclusive-OR them together and display the result in hexadecimal.

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
	
	msgAND BYTE "AND Operation Selected - Now pass me the necessary Hex digits",0 
	msgOR BYTE "OR Operation Selected - Now pass me the necessary Hex digits",0 
	msgNOT BYTE "NOT Operation Selected - Now pass me the necessary Hex digit",0 
	msgXOR BYTE "XOR Operation Selected - Now pass me the necessary Hex digits",0
	msgEXIT BYTE "EXIT Operation Selected - Bye!",0
	
	msg1 BYTE "Give me the first digit",0
	msg2 BYTE "Give me the second digit",0
.CODE
	main PROC
	
		;ask for input
		mov edx, OFFSET prompt 
		call writeString
		
		;read input
		call crlf
		call ReadChar
		
		mov ebx, OFFSET CaseTable ;start reading Case table
		mov ecx, NumberOfEntries ;set loop counter
		
		FINDMATCH:
			cmp al, [ebx] ;check for match with casetable
			jne NO 
			
			call NEAR PTR [ebx+1] ;check what is right after the lookup value
			call crlf ;new line
			jmp DONE
		;if no match then move to next location on table
		NO:
			add ebx, EntrySize
			loop FINDMATCH
		DONE:
		
		;delay so you can see output on execution
		mov eax, 3000
		call delay

		INVOKE ExitProcess, 0
	main ENDP
	
	;possible selection in table procs----------
	
	A_N_D PROC
		MOV edx, OFFSET msgAND
		call printEDX
		
		call ASK1
		call ASK2
		
		and eax, edi
		call writeHex
		call crlf
		
		RET
	A_N_D ENDP
	
	O_R PROC
		MOV edx, OFFSET msgOR
		call printEDX
		
		call ASK1
		call ASK2
		
		or eax, edi
		call writeHex
		call crlf
		
		RET
	O_R ENDP
	
	N_O_T PROC
		MOV edx, OFFSET msgNOT
		call printEDX
		
		call ASK1
		
		not eax
		call writeHex
		call crlf
		
		RET
	N_O_T ENDP
	
	X_O_R PROC
		MOV edx, OFFSET msgXOR
		call printEDX
		
		call ASK1
		call ASK2
		
		xor eax, edi
		call writeHex
		call crlf
		
		RET
	X_O_R ENDP
	
	E_X_I_T PROC
		MOV edx, OFFSET msgEXIT
		call printEDX
		RET
	E_X_I_T ENDP
	
	;helper procs----------
	
	printEDX PROC ;edx should already point to the offset of the string you want to print
		call writeString
		call crlf
		RET
	printEDX ENDP
	
	ASK1 PROC
		mov edx, OFFSET msg1
		call printEDX
		call readHex
		mov edi, eax ;save eax in edi
		ret
	ASK1 ENDP
	
	ASK2 PROC
		mov edx, OFFSET msg2
		call printEDX
		call readHex
		ret
	ASK2 ENDP

END main



