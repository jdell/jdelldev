//
//  plusSignAppDelegate.h
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright Genki-Oki 2009. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "cocos2d.h"
#import "BlankScene.h"
#import "PSConstants.h"
#import "IntroScene.h"
#import "MainMenuScene.h"
#import "TeachMeMenuScene.h"
#import "ScoreBoardScene.h"
#import <MediaPlayer/MediaPlayer.h>
#import "SimpleAudioEngine.h"

@interface plusSignAppDelegate : NSObject <UIApplicationDelegate> {
	
    MPMoviePlayerController *moviePlayer;
}

@end

