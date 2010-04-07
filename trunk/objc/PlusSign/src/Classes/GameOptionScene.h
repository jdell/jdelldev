//
//  GameOptionScene.h
//  plusSign
//
//  Created by Genki-Oki on 11/8/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "BackgroundGameOptionLayer.h"
#import "ButtonGameOptionMenuLayer.h"
#import "Button.h"
#import "MainMenuScene.h"
#import "GameScene.h"

typedef enum psSignValues{
	PLUS= 1,
	MINUS = 2,
	TIMES = 3,
	DIVISION = 4
} SignValue;


@interface GameOptionScene : Scene {

}

@end
