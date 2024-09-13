#include <stdint.h>
#include <stdio.h>
#include "Utility.h"

// Function to create a simple blocking delay (not precise)
void Delay_ms(uint32_t ms) {
    volatile uint32_t Counter = 0x00;
    for (uint32_t i = 0; i < ms * 1000; i++) {
        Counter++;
    }
}

int main() {
	
    // Pointer to access peripheral registers
    volatile uint32_t* ptr;

    // Enable the clock for GPIOD (AHB1 bus)
    ptr = (uint32_t*)(RCC_BASE_ADDRESS + RCC_AHB1_OFFSET);
    *ptr |= 0x08;  // Enable GPIOD (bit 3 corresponds to GPIOD)

    // Configure GPIOD pins 12, 13, 14, 15 as output (LED pins)
    ptr = (uint32_t*)(GPIOD_BASE_ADDRESS + GPIOD_MODER_OFFSET);
    *ptr &= ~(0xFF << 24);  // Clear bits 24-31 (MODER12-15)
    *ptr |= (0x55 << 24);   // Set pins 12, 13, 14, 15 as output (01 in MODER)

    // Set GPIOD pins 12 (turn on LED)
    ptr = (uint32_t*)(GPIOD_BASE_ADDRESS + GPIOD_BSRR_OFFSET);
		
    // Main loop to toggle LEDs
    while (1) {					
			
//        *ptr |= (1 << 12);    			// Set pin 12 high
//        Delay_ms(100);       			  // Wait for 100 ms      
//        *ptr |= (1 << (12 + 16));   // Set pin 12 low by setting the RESET pin to High, therefore we clear the half of register.	
//        Delay_ms(100);       			  // Wait for 100 ms				
//						
//			  *ptr |= (1 << 13);    		  // Set pin 13 high
//        Delay_ms(100);       			  // Wait for 500 ms       
//        *ptr |= (1 << (13 + 16));   // Set pin 13 low						
//        Delay_ms(100);       			  // Wait for 100 ms			
//					
//				*ptr |= (1 << 14);    		  // Set pin 14 high
//        Delay_ms(100);       			  // Wait for 500 ms       
//        *ptr |= (1 << (14 + 16));   // Set pin 14 low			
//        Delay_ms(100);       			  // Wait for 100 ms			
//			
//				Delay_ms(100) ; 			
//				*ptr |= (1 << 15);    		  // Set pin 15 high
//        Delay_ms(100);       			  // Wait for 100 ms       
//        *ptr |= (1 << (15 + 16));   // Set pin 15 low 	
			
				// A better implementation of bit definitions
				*ptr |= BIT_12; *ptr |= BIT_14;
				Delay_ms(100) ; 
				*ptr |= BIT_28; *ptr |= BIT_30;
				Delay_ms(100) ; 
				
				*ptr |= BIT_13; *ptr |= BIT_15;
				Delay_ms(100) ; 
				*ptr |= BIT_29; *ptr |= BIT_31;
				Delay_ms(100) ; 				
				
				*ptr |= BIT_14; *ptr |= BIT_12;
				Delay_ms(100) ; 
				*ptr |= BIT_30; *ptr |= BIT_28;
				Delay_ms(100) ; 					
				
			  *ptr |= BIT_15; *ptr |= BIT_13;
				Delay_ms(100) ; 
				*ptr |= BIT_31; *ptr |= BIT_29;
				Delay_ms(100) ; 
				
				
				// Sequential display
				*ptr |= BIT_12; 
				Delay_ms(100) ; 
				*ptr |= BIT_28; 
				Delay_ms(100) ; 
				
				*ptr |= BIT_13; 
				Delay_ms(100) ; 
				*ptr |= BIT_29; 
				Delay_ms(100) ; 				
				
				*ptr |= BIT_14; 
				Delay_ms(100) ; 
				*ptr |= BIT_30;
				Delay_ms(100) ; 					
				
			  *ptr |= BIT_15; 
				Delay_ms(100) ; 
				*ptr |= BIT_31; 
				Delay_ms(100) ; 
				
				continue; 

	 	  //ptr = (uint32_t*)(GPIOD_BASE_ADDRESS + 0x01);  // 0x40020C00  +  0x30
			  ptr = (uint32_t*)(GPIOD_BASE_ADDRESS);  // 0x40020C00  +  0x30
      // ptr++; ptr++; ptr++;
       *ptr = (0xFF); 
	     *ptr = (0xAABBCCDD);
			 *ptr = (0x00000000); 	
			 
			 *ptr |= (uint32_t)(0xCA << 0);
			 *ptr = (0x00000000); 
		   *ptr |= (uint32_t)(0xCA << 8); 
			 *ptr = (0x00000000); 
		   *ptr |= (uint32_t)(0xCA << 16); 
			 *ptr = (0x00000000); 
       *ptr |= (uint32_t)(0xCA << 24); 	
			 
			 *ptr = ~(*ptr); 
			 *ptr = *ptr | *ptr; 
    }

    return 0xFF;
}
