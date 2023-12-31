



import pygame

pygame.init()

screen = pygame.display.set_mode((400, 400)) #window
square = pygame.Surface((20, 20))
square.fill ((255, 0, 0))

press = pygame.event.get
    w = 100
    h = 100
    left = 0
while True:
    if left:
        w += 1
    screen.blit(square,(100, 100))
    if press(pygame.QUIT):
        break
    for event in pygame.event.get():
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_RIGHT:
                left = 1
    

    pygame.display.update()
    
pygame.quit()
