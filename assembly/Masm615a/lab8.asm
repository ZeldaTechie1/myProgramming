TITLE lab8 (lab8.asm)
INCLUDE Irvine32.inc

INTEGER_COUNT = 3
ARRAY_SIZE  = 20

.data

strx BYTE "Integers to be added? ",0
stry BYTE "Enter a signed integer: ",0
strz BYTE "The sum of the integers is: ",0
array DWORD ARRAY_SIZE DUP(?)

.code
main PROC

	call Clrscr
	mov esi,OFFSET array
	
	call promptMes
	mov ecx,eax
	call PromptForIntegers
	call ArraySum
	call DisplaySum
	exit
	main ENDP

promptMes proc uses ecx edx esi
		mov edx,offset strx
		mov esi,offset array
		call writestring		
		call readint		
		call crlf		
		;call PromptForInteger
		ret
promptMes endp

PromptForIntegers PROC USES ecx edx esi
	
	mov edx,OFFSET stry ; "Enter a signed integer"

L1: call WriteString
	call ReadInt
	call Crlf
	mov [esi],eax
	add esi,TYPE DWORD
	loop L1
	ret
	PromptForIntegers ENDP

ArraySum PROC USES esi ecx

	mov eax,0 ; sum = 0

L1: add eax,[esi]
	add esi,TYPE DWORD
	loop L1
	ret
ArraySum ENDP

DisplaySum PROC USES edx

	mov edx,OFFSET strz ; "The sum of the..."
	call WriteString
	call WriteInt
	call Crlf
	ret
DisplaySum ENDP
END main
