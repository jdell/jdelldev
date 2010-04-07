//
//  TalkAction.m
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TalkAction.h"


@implementation TalkAction
+(id) actionWithDuration:(ccTime)t textToSay :(NSString*)text label:(Label*)lab
{	
	return [[[self alloc] initWithDuration:t 
							   textToSay:text
									 label:lab] autorelease];
}

-(id) initWithDuration:(ccTime)t textToSay:(NSString*)text label:(Label*)lab
{
	if( !(self=[super initWithDuration: t]) )
		return nil;
	
	_textToSay = text;
	_label = lab;
	return self;
}

-(void) startWithTarget:(id)targett
{
	[super startWithTarget: targett];
	_characterIndex = 0;
	_tempString =  [[NSMutableString alloc] initWithCapacity:[_textToSay length]];
}

-(void) update: (ccTime) t
{	
	_speedChar = ceil( ((t*[_textToSay length]) ) - [_tempString length] );
	for (int i=0; i<_speedChar; i++) {
		if (_characterIndex<_textToSay.length)
		{
			unichar c = [_textToSay characterAtIndex:_characterIndex];
			[_tempString appendFormat:@"%C",c];
			_characterIndex++;
			[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_VOICE_TALKING];
		}
		else
			break;
	}
	[_label setString:NSLocalizedString(_tempString, @"")];
}

@end
