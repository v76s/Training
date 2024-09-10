#include <stdint.h>
#include <stdio.h>

//GPIOA	0x40020000
//GPIOB	0x40020400
//GPIOC	0x40020800
//GPIOD	0x40020C00
//GPIOE	0x40021000
//GPIOH	0x40021C00

#define RCC_BASE_ADDRESS        0x40023800     // RCC Base address
#define RCC_AHB1_OFFSET         0x30

#define GPIOD_BASE_ADDRESS      0x40020C00     // GPIO-D Base address

#define GPIOD_MODER_OFFSET      0x00
#define GPIOD_BSRR_OFFSET       0x18

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
			
        *ptr = (1 << 12);    // Set pin 12 high
        Delay_ms(100);       // Wait for 100 ms
        // Reset GPIOD pins 12 (turn off LED)
        *ptr = (1 << (12 + 16));  // Set pin 12 low
			  // XXXXXXXXXXX
        Delay_ms(100);       // Wait for 100 ms				
						
			  *ptr = (1 << 13);    // Set pin 13 high
        Delay_ms(100);       // Wait for 500 ms
        // Reset GPIOD pins 13 (turn off LED)
        *ptr = (1 << (13 + 16));  // Set pin 13 low			
			  // XXXXXXXXXXX
        Delay_ms(100);       // Wait for 100 ms			
					
				*ptr = (1 << 14);    // Set pin 14 high
        Delay_ms(100);       // Wait for 500 ms
        // Reset GPIOD pins 14 (turn off LED)
        *ptr = (1 << (14 + 16));  // Set pin 14 low
				// XXXXXXXXXXX
        Delay_ms(100);       // Wait for 100 ms			
			
				Delay_ms(100) ; 			
				*ptr = (1 << 15);    // Set pin 15 high
        Delay_ms(100);       // Wait for 100 ms
        // Reset GPIOD pins 15 (turn off LED)
        *ptr = (1 << (15 + 16));  // Set pin 15 low 	
    }

    return 0xFF;
}
