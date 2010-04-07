//
//  TalkAction.h
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "SimpleAudioEngine.h"
#import "PSConstants.h"


@interface TalkAction: IntervalAction <NSCopying>  {
	NSString *_textToSay;
	Label *_label;
	
	int _characterIndex;
	NSMutableString *_tempString;
	int _speedChar;
}

+(id) actionWithDuration:(ccTime)duration
			 textToSay :(NSString*)text 
			 label:(Label*)lab;
-(id) initWithDuration:(ccTime)duration 
			textToSay:(NSString*)text
		    label:(Label*)lab ;

@end
