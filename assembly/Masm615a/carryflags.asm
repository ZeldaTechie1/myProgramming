TITLE  Carry Flags       (carryflags.asm)


INCLUDE Irvine32.inc

.data
Rval SDWORD ?
Xval SDWORD 26
Yval SDWORD 30
Zval SDWORD 40

.code
main PROG
	mov  eax,Xval
	sub  eax,Zval		; Sign flag will be set
	call DumpRegs
	
	mov ebx,Yval
	sub ebx,Yval
	call DumpRegs

	exit
main ENDP
END main