//
//  GivingupGameLayer.h
//  plusSign
//
//  Created by Genki-Oki on 2/10/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "Button.h"
#import "PSConstants.h"
@class MainMenuScene;
@class ControlGameLayer;


@interface GivingupGameLayer : Layer {
	Button *noButton;
	Button *yeahButton;
}

@end
