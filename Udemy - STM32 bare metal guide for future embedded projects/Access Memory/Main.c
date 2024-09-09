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
	ptr2 = (uint16_t*)0x20000000;
	*ptr2 = 0x219;  // where we have MSB = 0x02 and LSB = 0x19
	ptr2++ ; 
	*ptr2 = 0x219;  // We see that the 0x19 is loaded in memory earlier than 0x02
	
	struct object
	{
		uint32_t bytes_4 ; 
		uint16_t bytes_2 ; 
		uint8_t  bytes_1a ; 
		uint8_t  bytes_1b; 
	};
	
	struct object* objPtr ; 
	objPtr = (struct object*)0x20000000; 
	
	// 8 7 6 5 4 3 2 1
	
	// 8 7 6 5, 0x05060708; 
	objPtr->bytes_4 = 0x05060708; 
	
	// 0x0304
	objPtr->bytes_2 = 0x0304; 
	
	// 0x02
	objPtr->bytes_1a = 0x02; 
	
	// 0x01
	objPtr->bytes_1b = 0x01; 	
	
	while(1)
	{
		
		
	}	
}