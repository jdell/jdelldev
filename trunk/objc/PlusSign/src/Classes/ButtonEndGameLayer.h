//
//  ButtonEndGameLayer.h
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "GameState.h"
#import "GameLayer.h"
#import "MainMenuScene.h"


@interface ButtonEndGameLayer : Layer {
	Sprite *gabrielSprite;
	Button * doneButton;
	
	Sprite * gabrielTalking;
	Animation *talking;
	
	BOOL lost;
}

@end
