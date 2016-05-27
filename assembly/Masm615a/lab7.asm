TITLE Sum of integers

INCLUDE Irvine32.inc

.data

inte1	BYTE "Give me an integer: ", 0
inte2	BYTE "Give me another integer: ", 0
result  BYTE "The sum is = ", 0
row     BYTE 10
col     BYTE 20

.code

main PROC

			

	
	call Clrscr	;Clears screen
	mov dh, row	
	mov dl, col
	call GotoXY	;Sets cursos to center

	
	mov edx, OFFSET inte1	;prompt for integer
	call WriteString
	call ReadInt

	
	push eax	;integer stack

	
	mov dh, row	;Clears screen
	inc dh		
	mov dl, col
	call GotoXY	;Sets cursor to center

	
	mov edx, OFFSET inte2	;prompt second int.
	call WriteString
	call ReadInt

	
	push eax	;int stack

	
	pop ebx		;restores ints in eax and ebx
	pop eax

	
	add eax, ebx	;adding ints

	mov dh, row	;set cursor 2 row below at the middle of the screen
	add dh, 2
	mov dl, col
	call GotoXY

	
	mov edx, OFFSET result	;print the sum
	call WriteString
	call WriteInt

	
	
	exit

main ENDP

END main
