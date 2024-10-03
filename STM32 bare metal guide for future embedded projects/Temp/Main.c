#include <stdint.h>
#include "ImportFile1.h"
#include "stm32f4xx.h"                  // Device header

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
	
	*ptr1byte = 0x00; 
	*ptr2byte = 0xEEFF; 
	*ptr4byte = 0x99AABBCC; 	
	
	
	
  *ptr1byte  = 0x00;
	*ptr1byte |= 0x02; 
	*ptr1byte |= 0x04; 
	*ptr1byte |= 0x08; 
	*ptr1byte |= 0x10; 
	*ptr1byte |= 0x20; 
	*ptr1byte |= 0x40; 
	*ptr1byte |= 0x80; 
	*ptr1byte |= 0xFF; 
	
  *ptr1byte = 0x00;
	*ptr1byte = 0x02; 
	*ptr1byte = 0x04; 
	*ptr1byte = 0x08; 
	*ptr1byte = 0x10; 
	*ptr1byte = 0x20; 
	*ptr1byte = 0x40; 
	*ptr1byte = 0x80; 
	*ptr1byte = 0xFF; 	
	
	
  *ptr1byte  = 0xFF;
	*ptr1byte &= 0x02; 
	*ptr1byte &= 0x04; 
	*ptr1byte &= 0x08; 
	*ptr1byte &= 0x10; 
	*ptr1byte &= 0x20; 
	
	*ptr1byte = 0x01; 
	*ptr1byte |= (1 << 0);
	*ptr1byte |= (1 << 1);
	*ptr1byte |= (1 << 2);
	*ptr1byte |= (1 << 3);
	*ptr1byte |= (1 << 4);
	*ptr1byte |= (1 << 5);
	
	*ptr1byte = 0x00; 
	*ptr1byte = (1 << 0);
	*ptr1byte = (1 << 1);
	*ptr1byte = (1 << 2);
	*ptr1byte = (1 << 3);
	*ptr1byte = (1 << 4);
	*ptr1byte = (1 << 5);	
	*ptr1byte = (1 << 6);
	*ptr1byte = (1 << 7);
	*ptr1byte = ~(uint8_t)(1 << 7);
	*ptr1byte = (1 << 0);
	*ptr1byte &= ~(uint8_t)(1 << 7);
	*ptr1byte &= ~(uint8_t)(1 << 3);
	*ptr1byte &= ~(uint8_t)(0x03 << 3);
	
	*ptr1byte = 0x07 ; 
	*ptr1byte = ~(uint8_t)(1<<4);  
	*ptr1byte &= ~(uint8_t)(1<<4);
	
	
	 ptr4byte = (uint32_t*)(0x20001000);
	 *ptr4byte = 0xAABBCCDD; 
	 *ptr4byte |= (01 << 1); 
	 *ptr4byte = 0x00000000;
	 *ptr4byte |= (1 << 12); 
	 
	  ptr4byte++ ; 
	 *ptr4byte |= ~(uint32_t)(1<<12) ; 
	 
	 ptr4byte++ ; 
	 *ptr4byte &= ~(uint32_t)(0x03<<24) ; 
						
	return 0; 
}