# CS_ARCH_X86, CS_MODE_32, CS_OPT_SYNTAX_ATT
0x8b,0x03 = movl (%ebx), %eax
0x89,0x4b,0x04 = movl %ecx, 4(%ebx)
0x8b,0x04,0x85,0x04,0x00,0x00,0x00 = movl 4(, %eax, 4), %eax
0x8b,0x04,0x85,0x04,0x00,0x00,0x00 = movl 4(, %eax, 4), %eax
0x8b,0x04,0x06 = movl (%esi, %eax), %eax
0x8b,0x04,0x06 = movl (%esi, %eax), %eax
0x8b,0x04,0x86 = movl (%esi, %eax, 4), %eax
0x8b,0x04,0x86 = movl (%esi, %eax, 4), %eax
0x8b,0x44,0x06,0x04 = movl 4(%esi, %eax), %eax
0x8b,0x44,0x06,0x04 = movl 4(%esi, %eax), %eax
0x8b,0x44,0x06,0x04 = movl 4(%esi, %eax), %eax
0x8b,0x44,0x06,0x04 = movl 4(%esi, %eax), %eax
0x8b,0x44,0x46,0x04 = movl 4(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x04 = movl 4(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x04 = movl 4(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x04 = movl 4(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x08 = movl 8(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x08 = movl 8(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x08 = movl 8(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x08 = movl 8(%esi, %eax, 2), %eax
0x8b,0x44,0x46,0x10 = movl 16(%esi, %eax, 2), %eax
0x0f,0x18,0x40,0x40 = prefetchnta 64(%eax)
0x60 = pushal 
0x61 = popal 
0x60 = pushal 
0x61 = popal 