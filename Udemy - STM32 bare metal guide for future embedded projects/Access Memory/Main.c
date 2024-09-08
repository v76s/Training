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
	
	// Investigation of the endiness of the hardware	
	uint16_t* ptr2 ; 
	ptr2 = (uint16_t*)0x2000000;
	*ptr2 = 0x219;  // where we have MSB = 0x02 and LSB = 0x19
	ptr2++ ; 
	*ptr2 = 0x219;  // We see that the 0x19 is loaded in memory earlier than 0x02
	
	while(1)
	{
		
		
	}	
}