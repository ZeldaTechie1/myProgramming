TITLE Lab9             (lab9.asm)

INCLUDE Irvine32.inc

.data
Menu BYTE "Choose one: ",0dh,0ah
  BYTE "1 x AND y",0dh,0ah
  BYTE "2 x OR y",0dh,0ah
  BYTE "3 NOT x",0dh,0ah
  BYTE "4 x XOR y",0dh,0ah
  BYTE "5 Exit Program",0
Msg1 BYTE "You pick 1 x AND y ",0
Msg2 BYTE "You pick 2 x OR y ",0
Msg3 BYTE "You pick 3 NOT x ",0
Msg4 BYTE "You pick 4 x XOR y ",0
Msg5 BYTE "You pick 5 Good-Bye",0

n1  BYTE "Enter one hex number",0
n2  BYTE "Enter two hex numbers",0
hexVal DWORD ?

.code
main PROC

	mov edx,OFFSET Menu
	call WriteString
	call Crlf

	mov eax,0
	call ReadInt
	
	.IF (eax==1)
		mov edx, OFFSET msg1
		call WriteString
		call crlf
		mov edx, OFFSET n2
		call WriteString
		call Crlf
		call ReadHex
		mov hexVal,eax
		call ReadHex
		AND eax,hexVal
		call WriteHex
		call Crlf
		jmp quit

	.ELSEIF (eax==2)
		mov edx, OFFSET msg2
		call WriteString
		call crlf
		mov edx,OFFSET n2
		call WriteString
		call Crlf
		call ReadHex
		mov hexVal,eax
		call ReadHex
		OR eax,hexVal
		call WriteHex
		call Crlf
		jmp quit

	.ELSEIF (eax==3)
		mov edx, OFFSET msg3
		call WriteString
		call crlf
		mov edx,OFFSET n1
		call WriteString
		call Crlf
		call ReadHex
		NOT eax
		call WriteHex
		call Crlf
		jmp quit
		
	.ELSEIF (eax==4)
		mov edx, OFFSET msg4
		call WriteString
		call crlf
		mov edx,OFFSET n2
		call WriteString
		call Crlf
		call ReadHex
		mov hexval,eax
		call ReadHex
		XOR eax,hexVal
		call WriteHex
		call Crlf
		jmp quit

	.ELSEIF (eax==5)
		mov edx, OFFSET msg5
		call WriteString
		
		jmp quit


	.ENDIF

quit:
	call crlf
	mov eax,5000
	call Delay
	exit

main ENDP
END main