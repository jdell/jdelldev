//
//  ButtonGameOptionMenuLayer.h
//  plusSign
//
//  Created by Genki-Oki on 12/22/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "Button.h"
#import "MainMenuScene.h"
#import "TouchSprite.h"
#import "GameState.h"


@interface ButtonGameOptionMenuLayer : Layer {
	Sprite *gabrielSprite;
	Animation *gabrielTalking;
	Label *words;
	Button * plusButton;
	Button * minusButton;
	Button * timesButton;
	Button * divisionButton;
	Button * doneButton;
	ButtonItem *cakeButton;
	ButtonItem *happyButton;
	ButtonItem *toughButton;
	
	int signsCounter;
	id actionTalking;
}
- (void) setMode:(tMODE) mode sprite:(Sprite *) sprite;

@end
