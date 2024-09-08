#include <stdint.h>

int main()
{
	
	// Access memory and update content
	
	uint8_t* ptr; 
	ptr = (uint8_t*)0x20000000;
	*ptr = 0x25 ; 
	
	uint8_t tmp ; 
	tmp = *ptr ; 
	
	ptr = ptr + 5 ; 
	*ptr = tmp ; 
	
	// Update the memory address in bitwise form, we're done with ptr, overwrite it. 
	
	ptr = (uint8_t*)0x20001000; 
	*ptr |= (0x08 | 0x20) ;  // which is actually the OR operation for (00001000 | 00100000) = (00101000)			
	
	while(1)
	{
		
		
	}	
}