;The greatest common divisor (GCD) of two integers is the largest integer that will evenly divide both integers. 
;The GCD algorithm involves integer division in a loop, described by the following pseudocode:
COMMENT ?
int GCD(int x, int y) 
{ 
	x = abs(x) // absolute value
	y = abs(y) 
	do 
	{ 
		int n = x % y x = y y = n 
	} while (y > 0) 
	
	return x 
} 
?
;Implement this function in assembly language and write a test program that calls the function several times, passing it different values. Display all results on the screen
;By: Bryan Cancel

.386
.MODEL flat, stdcall
.STACK 4096
ExitProcess PROTO, dwExitCode:DWORD

INCLUDE INCLUDE\Irvine32.inc

.DATA
	askMsg BYTE "Do you want to get the Greatest Common Divisor of two numbers? (Y/N)",0
	exitMsg BYTE "You have exited the program",0
	firstNumMsg BYTE "Give me the first number",0
	secondNumMsg BYTE "Now the second number",0
	resultMsg BYTE "Your GCD is: ",0
	x DWORD ?
	y DWORD ?
	n DWORD ?
.CODE
	main PROC
		;loop that repeats and calcs the GCD until you get tired of it
		ASK:
		
			;ask whether or not they want to get the GCD of two nums
			MOV EDX, OFFSET askMsg
			call writeString
			call crlf
			
			;grab a response (it will be in al)
			call ReadChar
			
			;check if the response was Y
			cmp al, 'Y'
			;if it isnt Y then its a No so jump to the end
			jne DONE
			
			GO:
			;procedure call here
			call GCD
			
			;ask again until the user stops wanting to calculate GCD
			jmp ASK
		
		DONE:
		cmp al, 'y'
		je GO
		
		;message to let you know you have exited the program
		MOV EDX, OFFSET exitMsg
		call writeString
		call crlf
		
		;a delay so you have a chance to look at the output before the program closes
		mov eax, 5000
		call delay

		INVOKE ExitProcess, 0
	main ENDP

;get GCD of two integers passed
	GCD PROC
		;ask for numbers and store them
			;ask for number #1
			MOV EDX, OFFSET firstNumMsg
			call writeString
			call crlf
			
			call ReadHex
			mov ebx, eax ;store the number in ebx (bigger)
			
			;ask for number #2
			MOV EDX, OFFSET secondNumMsg
			call writeString
			call crlf
			
			call ReadHex
			mov edx, eax ;store the number in edx (smaller)
		
		;absolute value of both numbers taken care of by readHex
			
		;calculate gcd
		call GCDhelper	

		;print gcd message
		MOV EDX, OFFSET resultMsg
		call writeString
		
		;print the result (since you call GCD, our number is in eax)
		call WriteDec

		call crlf
		call crlf
		
		ret
	GCD ENDP

COMMENT ?
int GCD(int x, int y) 
{ 
	x = abs(x) // absolute value
	y = abs(y) 
	do 
	{ 
		int n = x % y 
		x = y 
		y = n 
	} while (y > 0) 
	
	return x 
} 
?
;required info passed in ebx, and edx
	GCDhelper PROC
		;make sure you have the largest value as "x" (ebx) and the smallest as "y" (edx)
			cmp edx, ebx
			ja FIX
			jmp GOOD
			FIX:
				xchg ebx, edx
			GOOD:
		
		mov x, ebx
		mov y, edx
	
		;actual GCD func loop
		AGAIN:	

			mov esi, n
 
			;get n = x % y			
			mov edx, 0 ;clear higher end
			mov eax, x ;fill lower end
			div y
			;remainder will be stored in edx

			mov n, edx 
			
			mov edx, y ;intermediate step
			mov x, edx ;x = y (CHECK)	
			mov edx, n ;intermediate step
			mov y, edx ;y = n
			cmp y,0
		ja AGAIN
		
		;passing "x"(ebx) to eax, so we can print later
		mov eax, esi
		ret
	GCDhelper ENDP
	
END main


