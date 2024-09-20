#include <stdint.h>

int main()
{
	uint8_t* ptr1byte ; 
	ptr1byte = (uint8_t*) (0x20000000); 
	
	uint16_t* ptr2byte ; 
	ptr2byte = (uint16_t*)(0x20000000); 
	
	uint32_t* ptr4byte ; 
	ptr4byte = (uint32_t*) (0x20000000);
	
	*ptr1byte = 0xAA;
	*ptr2byte = 0xBBCC; 
	*ptr4byte = 0x12345678; 
	
	ptr1byte += 1 ;
	ptr2byte++; 
	ptr4byte++; 
	
	*ptr1byte = 0xDD; 
	*ptr2byte = 0xEEFF; 
	*ptr4byte = 0x99AABBCC; 	
	
	return 0; 
}