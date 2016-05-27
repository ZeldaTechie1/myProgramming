TITLE Add and Subtract              (AddSub.asm)

; This program adds and subtracts 32-bit integers.
; Last update: 2/1/02

INCLUDE Irvine32.inc

.code
main PROC

	mov ax,1Fh		; AX = 1Fh;
	sub ax,5h		; AX = 5h
	sub ax,6h		; AX = 6h
	sub ax,7h		; AX = 7h
	call DumpRegs

	exit
main ENDP
END main