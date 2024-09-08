#include <stdint.h>

int main()
{
	
	uint8_t* ptr; 
	ptr = (uint8_t*)0x20000000;
	*ptr = 0x25 ; 
	
	uint8_t tmp ; 
	tmp = *ptr ; 
	
	ptr = ptr + 5 ; 
	*ptr = tmp ; 
	
	while(1)
	{
		
		
	}	
}